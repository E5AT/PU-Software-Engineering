// Application header with logo and navigation
import React from 'react';
import { Link, useLocation } from 'react-router-dom';
import logo from '../assets/images/logo.png';

const Header = () => {
  const location = useLocation();

  // Check if current path matches link
  const isActive = (path) => {
    return location.pathname === path;
  };

  // Generate classes for navigation links based on active state
  const linkClasses = (path) => `text-base font-medium transition-colors duration-300 ${isActive(path) ? 'text-blue-600' : 'text-gray-600'} hover:text-blue-600`;

  return (
    <header className="sticky top-0 z-50 bg-white border-b border-gray-200 shadow-md">
      <div className="max-w-7xl mx-auto px-4 py-4 flex justify-between items-center">
        <Link to="/" className="flex items-center gap-3">
          <img src={logo} alt="CineLog Logo" className="w-8 h-8" />
          <span className="text-2xl font-bold text-blue-600">CineLog</span>
        </Link>
        <nav className="flex gap-8">
          <Link to="/" className={linkClasses('/')}>Movies</Link>
          <Link to="/add" className={linkClasses('/add')}>Add Movie</Link>
        </nav>
      </div>
    </header>
  );
};

export default Header;
