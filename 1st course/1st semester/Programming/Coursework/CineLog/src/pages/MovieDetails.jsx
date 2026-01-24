// Movie details page with full information
import React, { useState, useEffect } from 'react';
import { Link, useParams, useNavigate } from 'react-router-dom';
import { Star, Heart } from 'lucide-react';
import { getMovieById, deleteMovie } from '../lib/movieApi';
import Button from '../components/Button';
import Modal from '../components/Modal';

const MovieDetails = () => {
  const { id } = useParams();
  const navigate = useNavigate();

  const [movie, setMovie] = useState(null);
  const [loading, setLoading] = useState(true);
  const [isModalOpen, setIsModalOpen] = useState(false);

  // Load movie on component mount; depends on id
  useEffect(() => {
    loadMovie();
  }, [id]);

  // Fetch movie by id from API
  const loadMovie = async () => {
    try {
      setLoading(true);
      const data = await getMovieById(id);
      setMovie(data);
    } catch (error) {
      console.error('Failed to load movie:', error);
      alert('Failed to load movie: ' + error.message);
    } finally {
      setLoading(false);
    }
  };

  // CSS classes for status badge
  const getStatusClass = (status) => {
    if (!status) return "bg-gray-100 text-gray-800";
    const statusStyles = {
      "Watched": "bg-green-100 text-green-800",
      "Watching": "bg-blue-100 text-blue-800",
      "To Watch": "bg-orange-100 text-orange-800"
    };
    return statusStyles[status] || "bg-gray-100 text-gray-800";
  };

  // Delete movie and navigate to home
  const handleDelete = async () => {
    try {
      await deleteMovie(id);
      navigate('/');
    } catch (error) {
      console.error('Failed to delete movie:', error);
      alert('Failed to delete movie: ' + error.message);
    }
  };

  if (loading) {
    return (
      <div className="max-w-6xl mx-auto px-4 py-8 text-center">
        <p className="text-gray-600">Loading...</p>
      </div>
    );
  }

  if (!movie) {
    return (
      <div className="max-w-6xl mx-auto px-4 py-8 text-center">
        <p className="text-gray-600">Movie not found</p>
        <Link to="/" className="text-blue-600 hover:text-blue-800 mt-4 inline-block">
          ← Back to Movies
        </Link>
      </div>
    );
  }

  return (
    <div className="max-w-6xl mx-auto px-4 py-8">
      <Link to="/" className="text-blue-600 hover:text-blue-800 mb-6 inline-block font-medium">
        ← Back to Movies
      </Link>

      <div className="flex flex-col lg:flex-row gap-8">
        {/* Poster */}
        <div className="lg:w-[350px] flex-shrink-0">
          {movie.poster_url ? (
            <img src={movie.poster_url} alt={movie.title} className="w-full h-auto rounded-lg shadow-md" />
          ) : (
            <div className="w-full h-[525px] bg-gray-200 rounded-lg flex items-center justify-center text-gray-500">
              No Poster
            </div>
          )}
        </div>

        {/* Details */}
        <div className="flex-1 space-y-6">
          <div>
            <h1 className="text-4xl font-bold text-gray-900 mb-2">
              {movie.title} ({movie.year})
            </h1>
            <p className="text-lg text-gray-600 italic">Directed by {movie.director}</p>
          </div>

          {/* Movie Info Card */}
          <div className="bg-white shadow-md rounded-lg p-6 space-y-4">
            <div>
              <span className="font-semibold text-gray-700">Genre:</span>
              <span className="ml-2 text-gray-600">{movie.genre}</span>
            </div>
            <div className="flex items-center gap-6">
              <div className="flex items-center gap-2">
                <Star className="w-5 h-5 text-yellow-500" />
                <span className="text-gray-700 font-medium">
                  IMDb: {movie.imdb_rating || 'N/A'}/10
                </span>
              </div>
              <div className="flex items-center gap-2">
                <Heart className="w-5 h-5 text-red-500" />
                <span className="text-gray-700 font-medium">
                  Your Rating: {movie.personal_rating || 'Not rated'}/10
                </span>
              </div>
            </div>
            <div>
              <span className="font-semibold text-gray-700 mr-2">Status:</span>
              <span className={`inline-flex items-center px-3 py-1 rounded-full text-sm font-medium ${getStatusClass(movie.status)}`}>
                {movie.status}
              </span>
            </div>
          </div>

          {/* Notes Card */}
          <div className="bg-white shadow-md rounded-lg p-6">
            <h3 className="text-xl font-bold text-gray-900 mb-4">Your Notes</h3>
            {movie.notes ? (
              <p className="text-gray-700 leading-relaxed whitespace-pre-wrap">{movie.notes}</p>
            ) : (
              <p className="text-gray-400 italic">No notes added yet.</p>
            )}
          </div>

          {/* Action Buttons */}
          <div className="flex gap-4">
            <Button variant="secondary" onClick={() => navigate(`/edit/${id}`)}>
              Edit Movie
            </Button>
            <Button variant="danger" onClick={() => setIsModalOpen(true)}>
              Delete Movie
            </Button>
          </div>
        </div>
      </div>

      {/* Delete Confirmation Modal */}
      <Modal
        isOpen={isModalOpen}
        onClose={() => setIsModalOpen(false)}
        onConfirm={handleDelete}
        title="Delete Movie"
        message="Are you sure you want to delete this movie? This action cannot be undone."
      />
    </div>
  );
};

export default MovieDetails;
