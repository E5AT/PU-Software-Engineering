// Page for adding new movies to the collection
import React, { useState } from "react";
import { Link, useNavigate } from 'react-router-dom';
import { fetchMovieByTitle } from '../lib/omdbApi';
import { createMovie } from '../lib/movieApi';
import Button from '../components/Button';
import RatingSelector from '../components/RatingSelector';
import StatusRadio from '../components/StatusRadio';

const AddMovie = () => {
  const navigate = useNavigate();

  // Initial movie data state
  const [movieData, setMovieData] = useState({
    title: "",
    year: "",
    genre: "",
    director: "",
    poster_url: "",
    imdb_rating: "",
    personal_rating: null,
    status: "To Watch",
    notes: "",
  });
  const [loading, setLoading] = useState(false);
  const [fetched, setFetched] = useState(false);

  // Fetch movie data from OMDb API
  const handleFetchFromOMDb = async () => {
    if (!movieData.title) {
      alert('Please enter a movie title');
      return;
    }

    try {
      setLoading(true);
      const omdbData = await fetchMovieByTitle(movieData.title, movieData.year);
      setMovieData({
        ...movieData,
        ...omdbData
      });
      setFetched(true);
    } catch (error) {
      alert('Movie not found: ' + error.message);
    } finally {
      setLoading(false);
    }
  };

  // Save movie to database
  const handleSave = async () => {
    if (!fetched) {
      alert('Please fetch movie data from OMDb first');
      return;
    }

    try {
      setLoading(true);
      await createMovie(movieData);
      navigate('/');
    } catch (error) {
      alert('Failed to save movie: ' + error.message);
    } finally {
      setLoading(false);
    }
  };

  // Update title and reset related fields
  const handleTitleChange = (e) => {
    setMovieData({
      ...movieData,
      title: e.target.value,
      genre: '',
      director: '',
      poster_url: '',
      imdb_rating: ''
    });
  };

  // Update year and reset related fields
  const handleYearChange = (e) => {
    const value = e.target.value;
    // Only allow numbers
    if (value === '' || /^\d{0,4}$/.test(value)) {
      setMovieData({
        ...movieData,
        year: value,
        genre: '',
        director: '',
        poster_url: '',
        imdb_rating: ''
      });
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

  return (
    <div className="max-w-4xl mx-auto px-4 py-8">
      <Link to="/" className="text-blue-600 hover:text-blue-800 mb-6 inline-block font-medium">← Back to Movies</Link>

      <h1 className="text-3xl font-bold mb-6 text-gray-900">Add New Movie</h1>

      {/* Section 1: Search Movie */}
      <div className="bg-white shadow-md rounded-lg p-6 mb-6">
        <h2 className="text-xl font-bold border-b-2 border-gray-200 pb-3 mb-4">1. Search Movie</h2>
        <div className="mb-4">
          <label className="block text-gray-700 font-medium mb-2">Movie Title *</label>
          <input
            className="w-full px-4 py-2 border-2 border-gray-300 rounded-md focus:outline-none focus:border-blue-600 transition-colors"
            type="text"
            placeholder="Enter movie title..."
            value={movieData.title}
            onChange={handleTitleChange}
          />
        </div>
        <div className="mb-4">
          <label className="block text-gray-700 font-medium mb-2">Year (optional)</label>
          <input
            className="w-48 px-4 py-2 border-2 border-gray-300 rounded-md focus:outline-none focus:border-blue-600 transition-colors"
            type="text"
            placeholder="e.g. 2010"
            value={movieData.year}
            onChange={handleYearChange}
          />
        </div>
        <Button variant="primary" onClick={handleFetchFromOMDb} disabled={loading}>
          {loading ? 'Fetching...' : 'Fetch from OMDb'}
        </Button>
      </div>

      {/* Section 2: Movie Information from OMDb */}
      <div className="bg-white shadow-md rounded-lg p-6 mb-6">
        <h2 className="text-xl font-bold border-b-2 border-gray-200 pb-3 mb-4">2. Movie Information (from OMDb)</h2>
        <div className="mb-4">
          <label className="block text-gray-700 font-medium mb-2">Genre</label>
          <input className="w-full px-4 py-2 border-2 border-gray-300 rounded-md bg-gray-100 text-gray-600" type="text" disabled value={movieData.genre} />
        </div>
        <div className="mb-4">
          <label className="block text-gray-700 font-medium mb-2">Director</label>
          <input className="w-full px-4 py-2 border-2 border-gray-300 rounded-md bg-gray-100 text-gray-600" type="text" disabled value={movieData.director} />
        </div>
        <div className="mb-4">
          <label className="block text-gray-700 font-medium mb-2">Poster URL</label>
          <input className="w-full px-4 py-2 border-2 border-gray-300 rounded-md bg-gray-100 text-gray-600" type="text" disabled value={movieData.poster_url} />
        </div>
        {movieData.poster_url && (
          <div className="mb-4">
            <label className="block text-gray-700 font-medium mb-2">Poster Preview</label>
            <img className="w-48 h-auto rounded-md shadow-md mt-4" src={movieData.poster_url} alt="Movie poster" />
          </div>
        )}
      </div>

      {/* Section 3: Personal Data */}
      <div className="bg-white shadow-md rounded-lg p-6 mb-6">
        <h2 className="text-xl font-bold border-b-2 border-gray-200 pb-3 mb-4">3. Your Personal Data</h2>
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
        <div>
          <label className="block text-gray-700 font-medium mb-2">Notes</label>
          <textarea
            className="min-h-[120px] w-full px-4 py-2 border-2 border-gray-300 rounded-md focus:outline-none focus:border-blue-600 transition-colors resize-y"
            placeholder="Write your personal notes here..."
            value={movieData.notes}
            onChange={handleNotesChange}
          ></textarea>
        </div>
      </div>

      {/* Action Buttons */}
      <div className="flex justify-end gap-4">
        <Link to="/" className="px-6 py-2 border-2 border-gray-300 text-gray-700 font-medium rounded-md hover:bg-gray-50 transition-colors inline-flex items-center">
          Cancel
        </Link>
        <Button variant="primary" onClick={handleSave} disabled={loading}>
          {loading ? 'Saving...' : 'Save Movie'}
        </Button>
      </div>
    </div>
  );
};

export default AddMovie;
