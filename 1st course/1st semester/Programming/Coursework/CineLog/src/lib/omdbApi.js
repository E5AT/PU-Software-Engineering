// OMDb API utility for fetching movie external data
const OMDB_API_KEY = import.meta.env.VITE_OMDB_API_KEY;
const OMDB_BASE_URL = "http://www.omdbapi.com/";

// Validate API key exists
if (!OMDB_API_KEY) {
  console.error("VITE_OMDB_API_KEY is not defined in environment variables");
}

export async function fetchMovieByTitle(title, year = null) {
  try {
    let url = `${OMDB_BASE_URL}?apikey=${OMDB_API_KEY}&t=${encodeURIComponent(
      title
    )}`;

    if (year) {
      url += `&y=${year}`;
    }

    // Fetch movie data from OMDb API
    const response = await fetch(url);
    const data = await response.json();

    // Handle API error or not found
    if (data.Response === "False") {
      throw new Error(data.Error || "Movie not found");
    }

    return {
      title: data.Title,
      year: parseInt(data.Year),
      genre: data.Genre,
      director: data.Director,
      poster_url: data.Poster !== "N/A" ? data.Poster : null,
      imdb_rating: data.imdbRating !== "N/A" ? data.imdbRating : null,
    };
  } catch (error) {
    console.error("OMDb API Error:", error);
    throw error;
  }
}
