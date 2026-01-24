// Movie card displaying basic movie info and actions
import React from 'react';
import { useNavigate } from 'react-router-dom';
import { Star, Heart } from 'lucide-react';
import Button from './Button';

const MovieCard = ({ movie, onEdit, onDelete }) => {
  const navigate = useNavigate();

  // Get CSS classes for status badge
  const getStatusClass = (status) => {
    if (!status) return "bg-gray-100 text-gray-800";
    const statusStyles = {
      "Watched": "bg-green-100 text-green-800",
      "Watching": "bg-blue-100 text-blue-800",
      "To Watch": "bg-orange-100 text-orange-800"
    };
    return statusStyles[status] || "bg-gray-100 text-gray-800";
  };

  return (
    <div className="bg-white rounded-lg shadow-md hover:shadow-xl transition-all duration-300 hover:-translate-y-2 overflow-hidden">
      <div className="aspect-[2/3] bg-gray-100 flex items-center justify-center">
        {movie.poster_url ? (
          <img src={movie.poster_url} alt={movie.title} className="w-full h-full object-cover" />
        ) : (
          <div className="text-gray-500 text-center">No Poster</div>
        )}
      </div>
      <div className="p-4 space-y-3">
        <h3 className="font-bold text-lg leading-tight text-gray-900 overflow-hidden"
          style={{
            display: '-webkit-box',
            WebkitLineClamp: 2,
            WebkitBoxOrient: 'vertical'
          }}
          title={movie.title}>
          {movie.title}
        </h3>
        <div className="flex items-center space-x-4 text-sm">
          <div className="flex items-center gap-1">
            <Star className="w-5 h-5 text-yellow-500" />
            <span>{movie.imdb_rating || 'N/A'}</span>
          </div>
          <div className="flex items-center gap-1">
            <Heart className="w-5 h-5 text-red-500" />
            <span>{movie.personal_rating || 'Not rated'}</span>
          </div>
        </div>
        <div className={`inline-flex px-3 py-1 rounded-full text-xs font-medium ${getStatusClass(movie.status)}`}>
          {movie.status}
        </div>
        <div className="flex space-x-2 pt-2">
          <Button variant="secondary" className="flex-1" onClick={() => navigate(`/edit/${movie.id}`)}>Edit</Button>
          <Button variant="primary" className="flex-1" onClick={() => navigate(`/movie/${movie.id}`)}>View</Button>
          <Button variant="danger" className="flex-1" onClick={() => onDelete(movie.id)}>Delete</Button>
        </div>
      </div>
    </div>
  );
};

export default MovieCard;
