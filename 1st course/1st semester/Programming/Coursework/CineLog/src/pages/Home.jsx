// Home page displaying movie collection
import React, { useState, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import MovieCard from '../components/MovieCard';
import SearchBar from '../components/SearchBar';
import FilterBar from '../components/FilterBar';
import Button from '../components/Button';
import Modal from '../components/Modal';
import { getAllMovies, deleteMovie } from '../lib/movieApi';

const Home = () => {
  const navigate = useNavigate();

  const [movies, setMovies] = useState([]);
  const [filteredMovies, setFilteredMovies] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);
  const [searchQuery, setSearchQuery] = useState('');
  const [statusFilter, setStatusFilter] = useState('All');
  const [sortBy, setSortBy] = useState('Title');

  // Load movies on component mount
  useEffect(() => {
    loadMovies();
  }, []);

  // Fetch all movies from API
  const loadMovies = async () => {
    try {
      setLoading(true);
      const data = await getAllMovies();
      setMovies(data || []);
    } catch (err) {
      console.error('Error loading movies:', err);
      setError(err.message);
    } finally {
      setLoading(false);
    }
  };

  // Filter and sort movies based on search, filter, sort; depends on those states
  useEffect(() => {
    let result = [...movies];

    if (searchQuery) {
      result = result.filter(movie =>
        movie.title.toLowerCase().includes(searchQuery.toLowerCase())
      );
    }

    if (statusFilter !== 'All') {
      result = result.filter(movie => movie.status === statusFilter);
    }

    result.sort((a, b) => {
      switch (sortBy) {
        case 'Title':
          return a.title.localeCompare(b.title);
        case 'Year':
          return (b.year || 0) - (a.year || 0);
        case 'Rating':
          return (b.personal_rating || 0) - (a.personal_rating || 0);
        default:
          return 0;
      }
    });

    setFilteredMovies(result);
  }, [movies, searchQuery, statusFilter, sortBy]);

  // Delete movie from database
  const [deleteId, setDeleteId] = useState(null);

  const handleDeleteClick = (id) => {
    setDeleteId(id);
  };

  const handleDeleteConfirm = async () => {
    try {
      await deleteMovie(deleteId);
      loadMovies();
    } catch (err) {
      console.error('Error deleting movie:', err);
      alert('Failed to delete movie: ' + err.message);
    } finally {
      setDeleteId(null);
    }
  };

  if (loading) {
    return (
      <div className="max-w-7xl mx-auto px-4 text-center py-8">
        <p className="text-gray-600">Loading movies...</p>
      </div>
    );
  }

  if (error) {
    return (
      <div className="max-w-7xl mx-auto px-4 text-center py-8">
        <p className="text-red-600">Error: {error}</p>
        <Button onClick={loadMovies} className="mt-4">Retry</Button>
      </div>
    );
  }

  return (
    <div className="max-w-7xl mx-auto px-4 py-8">
      <h1 className="text-3xl font-bold mb-6 text-gray-900">My Movie Collection</h1>

      <div className="flex flex-col sm:flex-row gap-4 mb-6">
        <SearchBar searchQuery={searchQuery} setSearchQuery={setSearchQuery} />
        <Button variant="primary" className="whitespace-nowrap" onClick={() => navigate('/add')}>+ Add Movie</Button>
      </div>

      <FilterBar
        statusFilter={statusFilter}
        setStatusFilter={setStatusFilter}
        sortBy={sortBy}
        setSortBy={setSortBy}
      />

      {filteredMovies.length === 0 ? (
        <div className="text-center py-16">
          <p className="text-gray-500 text-lg mb-4">
            {movies.length === 0 ? 'No movies yet. Add your first movie!' : 'No movies match your filters.'}
          </p>
          {movies.length === 0 && (
            <Button variant="primary" onClick={() => navigate('/add')}>Add Your First Movie</Button>
          )}
        </div>
      ) : (
        <div className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-6">
          {filteredMovies.map(movie => (
            <MovieCard
              key={movie.id}
              movie={movie}
              onDelete={handleDeleteClick}
            />
          ))}
        </div>
      )}
      <Modal
        isOpen={deleteId !== null}
        onClose={() => setDeleteId(null)}
        onConfirm={handleDeleteConfirm}
        title="Delete Movie"
        message="Are you sure you want to delete this movie? This action cannot be undone."
      />
    </div>
  );
};

export default Home;
