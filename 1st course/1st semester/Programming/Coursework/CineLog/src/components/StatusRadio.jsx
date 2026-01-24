// Status radio button group for movie watch status
import React from 'react';

const StatusRadio = ({ selectedStatus, onStatusChange }) => {
    const statuses = ['To Watch', 'Watching', 'Watched'];

    return (
        <div>
            <label className="block text-gray-700 font-medium mb-3">Status</label>
            <div className="flex gap-6">
                {statuses.map((status) => (
                    <label key={status} className="flex items-center gap-2 cursor-pointer">
                        <input
                            type="radio"
                            name="status"
                            value={status}
                            checked={selectedStatus === status}
                            // Update selected status on change
                            onChange={(e) => onStatusChange(e.target.value)}
                            className="w-4 h-4"
                        />
                        <span>{status}</span>
                    </label>
                ))}
            </div>
        </div>
    );
};

export default StatusRadio;
