// API functions for movie data operations
import { supabase } from "./supabaseClient";

// Fetch all movies
export async function getAllMovies() {
  const { data, error } = await supabase
    .from("movies")
    .select("*")
    .order("created_at", { ascending: false });

  if (error) throw error;
  return data;
}

// Fetch single movie by ID
export async function getMovieById(id) {
  const { data, error } = await supabase
    .from("movies")
    .select("*")
    .eq("id", id)
    .single();

  if (error) throw error;
  return data;
}

// Create new movie
export async function createMovie(movieData) {
  const { data, error } = await supabase
    .from("movies")
    .insert([movieData])
    .select()
    .single();

  if (error) throw error;
  return data;
}

// Update existing movie
export async function updateMovie(id, movieData) {
  const { data, error } = await supabase
    .from("movies")
    .update({
      ...movieData,
      updated_at: new Date().toISOString(),
    })
    .eq("id", id)
    .select()
    .single();

  if (error) throw error;
  return data;
}

// Delete movie
export async function deleteMovie(id) {
  const { error } = await supabase.from("movies").delete().eq("id", id);

  if (error) throw error;
  return true;
}
