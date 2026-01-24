// Filter bar for selecting movie status and sort order
import React from 'react';

const FilterBar = ({ statusFilter, setStatusFilter, sortBy, setSortBy }) => {
  return (
    <div className="flex flex-wrap gap-6 mb-8 p-4 bg-white rounded-lg shadow-sm">
      <div className="flex items-center gap-2">
        <label htmlFor="status" className="text-sm font-medium text-gray-700">Status:</label>
        <select
          id="status"
          value={statusFilter}
          // Update status filter on change
          onChange={(e) => setStatusFilter(e.target.value)}
          className="px-3 py-1 border-2 border-gray-300 rounded-md text-sm font-medium focus:outline-none focus:border-blue-600 transition-colors"
        >
          <option className="text-gray-700">All</option>
          <option className="text-gray-700">Watched</option>
          <option className="text-gray-700">Watching</option>
          <option className="text-gray-700">To Watch</option>
        </select>
      </div>

      <div className="flex items-center gap-2">
        <label htmlFor="sort" className="text-sm font-medium text-gray-700">Sort by:</label>
        <select
          id="sort"
          value={sortBy}
          // Update sort order on change
          onChange={(e) => setSortBy(e.target.value)}
          className="px-3 py-1 border-2 border-gray-300 rounded-md text-sm font-medium focus:outline-none focus:border-blue-600 transition-colors"
        >
          <option className="text-gray-700">Title</option>
          <option className="text-gray-700">Year</option>
          <option className="text-gray-700">Rating</option>
        </select>
      </div>
    </div>
  );
};

export default FilterBar;
