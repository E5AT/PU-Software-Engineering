// Page for editing movie personal data
import React, { useState, useEffect } from 'react';
import { Link, useParams, useNavigate } from 'react-router-dom';
import { getMovieById, updateMovie } from '../lib/movieApi';
import Button from '../components/Button';
import RatingSelector from '../components/RatingSelector';
import StatusRadio from '../components/StatusRadio';

const EditMovie = () => {
  const { id } = useParams();
  const navigate = useNavigate();

  const [movieData, setMovieData] = useState({
    title: '',
    year: '',
    genre: '',
    director: '',
    poster_url: '',
    imdb_rating: '',
    personal_rating: null,
    status: 'To Watch',
    notes: ''
  });
  const [loading, setLoading] = useState(true);

  // Load movie data on component mount; depends on id
  useEffect(() => {
    loadMovie();
  }, [id]);

  // Fetch movie data from API
  const loadMovie = async () => {
    try {
      setLoading(true);
      const data = await getMovieById(id);
      setMovieData(data);
    } catch (error) {
      console.error('Failed to load movie:', error);
      alert('Failed to load movie: ' + error.message);
    } finally {
      setLoading(false);
    }
  };

  // Update movie in database
  const handleUpdate = async () => {
    try {
      setLoading(true);
      await updateMovie(id, {
        personal_rating: movieData.personal_rating,
        status: movieData.status,
        notes: movieData.notes
      });
      navigate('/');
    } catch (error) {
      console.error('Failed to update movie:', error);
      alert('Failed to update movie: ' + error.message);
    } finally {
      setLoading(false);
    }
  };

  // Update personal rating
  const handleRatingSelect = (rating) => {
    setMovieData({ ...movieData, personal_rating: rating });
  };

  // Update status
  const handleStatusChange = (status) => {
    setMovieData({ ...movieData, status });
  };

  // Update notes
  const handleNotesChange = (e) => {
    setMovieData({ ...movieData, notes: e.target.value });
  };

  if (loading) {
    return <div className="text-center py-8 text-gray-600">Loading...</div>;
  }

  return (
    <div className="max-w-4xl mx-auto px-4 py-8">
      <Link to="/" className="text-blue-600 hover:text-blue-800 mb-6 inline-block font-medium">← Back to Movies</Link>

      <h1 className="text-3xl font-bold mb-6 text-gray-900">Edit Movie</h1>

      {/* Movie Information (read-only) */}
      <div className="bg-white shadow-md rounded-lg p-6 mb-6">
        <h2 className="text-xl font-bold border-b-2 border-gray-200 pb-3 mb-4">Movie Information</h2>
        <div className="mb-4">
          <label className="block text-gray-700 font-medium mb-2">Title</label>
          <input type="text" className="w-full px-4 py-2 border-2 border-gray-300 rounded-md bg-gray-100 text-gray-600 cursor-not-allowed" value={movieData.title} disabled />
        </div>
        <div className="mb-4">
          <label className="block text-gray-700 font-medium mb-2">Year</label>
          <input type="text" className="w-full px-4 py-2 border-2 border-gray-300 rounded-md bg-gray-100 text-gray-600 cursor-not-allowed" value={movieData.year} disabled />
        </div>
        <div className="mb-4">
          <label className="block text-gray-700 font-medium mb-2">Genre</label>
          <input type="text" className="w-full px-4 py-2 border-2 border-gray-300 rounded-md bg-gray-100 text-gray-600 cursor-not-allowed" value={movieData.genre} disabled />
        </div>
        <div className="mb-4">
          <label className="block text-gray-700 font-medium mb-2">Director</label>
          <input type="text" className="w-full px-4 py-2 border-2 border-gray-300 rounded-md bg-gray-100 text-gray-600 cursor-not-allowed" value={movieData.director} disabled />
        </div>
        <div className="mb-4">
          <label className="block text-gray-700 font-medium mb-2">Poster URL</label>
          <input type="text" className="w-full px-4 py-2 border-2 border-gray-300 rounded-md bg-gray-100 text-gray-600 cursor-not-allowed" value={movieData.poster_url} disabled />
        </div>
      </div>

      {/* Personal Data (editable) */}
      <div className="bg-white shadow-md rounded-lg p-6 mb-6">
        <h2 className="text-xl font-bold border-b-2 border-gray-200 pb-3 mb-4">Your Personal Data</h2>
        <div className="mb-6">
          <RatingSelector
            selectedRating={movieData.personal_rating}
            onRatingSelect={handleRatingSelect}
          />
        </div>
        <div className="mb-6">
          <StatusRadio
            selectedStatus={movieData.status}
            onStatusChange={handleStatusChange}
          />
        </div>
        <div className="mb-4">
          <label className="block text-gray-700 font-medium mb-2">Notes</label>
          <textarea
            className="w-full min-h-[120px] resize-vertical px-4 py-2 border-2 border-gray-300 rounded-md focus:outline-none focus:border-blue-600 transition-colors"
            placeholder="Write your personal notes here..."
            value={movieData.notes}
            onChange={handleNotesChange}
          ></textarea>
        </div>
      </div>

      {/* Action Buttons */}
      <div className="flex justify-end gap-4">
        <Link to="/" className="px-6 py-2 rounded-md font-medium transition-colors bg-white border-2 border-gray-300 text-gray-700 hover:bg-gray-50">Cancel</Link>
        <Button variant="primary" onClick={handleUpdate} disabled={loading}>
          {loading ? 'Updating...' : 'Update Movie'}
        </Button>
      </div>
    </div>
  );
};

export default EditMovie;
