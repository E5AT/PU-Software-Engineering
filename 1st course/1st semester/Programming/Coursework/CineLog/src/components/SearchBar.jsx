// Search input bar for filtering movies
import React from 'react';
import { Search } from 'lucide-react';

const SearchBar = ({ searchQuery, setSearchQuery }) => {
  return (
    <div className="relative">
      <Search className="absolute left-3 top-1/2 transform -translate-y-1/2 w-5 h-5 text-gray-400" />
      <input
        type="text"
        placeholder="Search movies..."
        value={searchQuery}
        // Update search query on change
        onChange={(e) => setSearchQuery(e.target.value)}
        className="flex-1 w-full pl-10 pr-4 py-2 border-2 border-gray-300 rounded-md text-gray-700 placeholder-gray-500 outline-none focus:border-blue-600 transition-colors"
      />
    </div>
  );
};

export default SearchBar;
