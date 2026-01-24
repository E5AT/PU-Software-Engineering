// Reusable button component with different variants and states
import React from 'react';

const Button = ({ children, variant = 'primary', onClick, disabled, type = 'button', className = '' }) => {
    const baseClasses = 'px-6 py-2 rounded-md font-medium transition-colors';
    const variants = {
        primary: 'bg-blue-600 hover:bg-blue-700 text-white',
        secondary: 'bg-green-600 hover:bg-green-700 text-white',
        danger: 'bg-red-600 hover:bg-red-700 text-white',
        outline: 'bg-white border-2 border-gray-300 text-gray-700 hover:bg-gray-50'
    };
    // Build button classes based on variant and disabled state
    const disabledClasses = disabled ? 'bg-gray-400 cursor-not-allowed hover:bg-gray-400' : '';
    const buttonClasses = `${baseClasses} ${disabled ? disabledClasses : variants[variant]} ${className}`.trim();

    return (
        <button type={type} onClick={onClick} disabled={disabled} className={buttonClasses}>
            {children}
        </button>
    );
};

export default Button;