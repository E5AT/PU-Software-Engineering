// src/AppRoutes.jsx
import { Routes, Route } from "react-router-dom";
import App from "./App.jsx";
import Home from "./pages/Home.jsx";
import AddMovie from "./pages/AddMovie.jsx";
import EditMovie from "./pages/EditMovie.jsx";
import MovieDetails from "./pages/MovieDetails.jsx";

const AppRoutes = () => {
  return (
    <App>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/add" element={<AddMovie />} />
        <Route path="/edit/:id" element={<EditMovie />} />
        <Route path="/movie/:id" element={<MovieDetails />} />
      </Routes>
    </App>
  );
};

export default AppRoutes;
