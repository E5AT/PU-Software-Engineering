// Rating selector component for 1-10 personal rating
import React from 'react';

const RatingSelector = ({ selectedRating, onRatingSelect }) => {
    return (
        <div>
            <label className="block text-gray-700 font-medium mb-3">Personal Rating (1-10)</label>
            <div className="flex flex-wrap gap-2">
                {[1, 2, 3, 4, 5, 6, 7, 8, 9, 10].map((num) => (
                    <button
                        key={num}
                        // Set personal rating on click
                        onClick={() => onRatingSelect(num)}
                        aria-label={`Rate ${num} out of 10`}
                        aria-pressed={selectedRating === num}
                        className={`w-12 h-12 rounded-md font-medium transition-all ${selectedRating === num
                                ? 'bg-blue-600 text-white'
                                : 'bg-gray-200 text-gray-700 hover:bg-gray-300'
                            }`}
                    >
                        {num}
                    </button>
                ))}
            </div>
        </div>
    );
};

export default RatingSelector;
