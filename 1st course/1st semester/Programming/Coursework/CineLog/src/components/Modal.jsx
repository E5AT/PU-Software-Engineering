// Modal dialog for confirmations
import React from 'react';
import Button from './Button';
import { useEffect } from 'react';

const Modal = ({ isOpen, onClose, onConfirm, title, message }) => {
    // Close modal on ESC key press
    useEffect(() => {
        const handleEscape = (e) => {
            if (e.key === 'Escape' && isOpen) {
                onClose();
            }
        };

        if (isOpen) {
            document.addEventListener('keydown', handleEscape);
            return () => document.removeEventListener('keydown', handleEscape);
        }
    }, [isOpen, onClose]);

    // Don't render if modal is not open
    if (!isOpen) return null;

    return (
        <div className="fixed inset-0 bg-black/50 flex items-center justify-center">
            <div className="bg-white max-w-md p-6 rounded-lg shadow-xl">
                <h2 className="text-xl font-bold mb-4">{title}</h2>
                <p className="text-gray-600 mb-6">{message}</p>
                <div className="flex justify-end gap-4">
                    <Button variant="outline" onClick={onClose}>Cancel</Button>
                    <Button variant="danger" onClick={onConfirm}>Confirm</Button>
                </div>
            </div>
        </div>
    );
};

export default Modal;