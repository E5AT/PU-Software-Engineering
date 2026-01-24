import React from "react";
import Header from "./components/Header";

const App = ({ children }) => {
  return (
    <div className="min-h-screen bg-gray-50 text-gray-900">
      {/* Header visible on all pages */}
      <Header />

      {/* Main content area */}
      <main className="max-w-7xl mx-auto px-4 py-8">{children}</main>
    </div>
  );
};

export default App;
