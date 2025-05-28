using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using ChinookMusicApp.Data;
using ChinookMusicApp.Models;


public class MusicQueryService {

    private readonly ApplicationDbContext _context;
    public MusicQueryService(ApplicationDbContext context) {

        _context = context;

    }

    async Task<List<string>> GetAllArtistsWithAlbums() {
        return await _context.Artist
        .Where(art => art.Albums.Count > 0)
        .Select(art => art.Name)
        .ToListAsync();
    }
    async Task<List<string>> GetAllArtistsWithMoreThanOneAlbum(){
        return await _context.Artist
        .Where(art => art.Albums.Count > 1)
        .Select(art => art.Name)
        .ToListAsync();
    }
    async Task<List<string>> GetArtistByNameWithAlbum(string artistName){
        return await _context.Artist
        .Where(art => art.Name.ToUpper() == artistName.ToUpper())
        .Select(art => art.Name)
        .Include(art => art.Album);

    }
    async Task<List<string>> GetTracksByAlbumId(int albumId){
        return await _context;
    }
    async Task<List<string>> GetAllGenresWithTracks(){
        return await _context;
    }
    async Task<List<string>> GetTracksByGenreId(int genreId){
        return await _context;
    }
    async Task<List<string>> GettotalTrackByAlbum(){
        return await _context;
    }
    async Task<List<string>> GetAlbumsByArtistId(int artistId){
        return await _context;
    }
    async Task<List<string>> GetAllPlaylistsWithTrack(){
        return await _context;
    }
    async Task<List<string>> GetAverageDurationByGenre(){
        return await _context;
    }

    async Task<List<string>> GetArtistsWithoutAlbums(){
        return await _context;
    }
    async Task<List<string>> GetTracksWithGenreAndAlbum() {
        return await _context;
    }
    async Task<List<string>> GetTrackDetails() {
        return await _context;
    }
    async Task<List<string>> GetAlbumsWithTrackDuration(){
        return await _context;
    }
    async Task<List<string>> GetGenreTrackCounts(){
        return await _context;
    }
    async Task<List<string>> GetPlaylistWithTrackCount(){
        return await _context;
    }
    async Task<List<string>> GetTracksByPlaylistId(int playlistId){
        return await _context;
    }
    async Task<List<string>> GetPlaylistWithMostTracks(){
        return await _context;
    }
    async Task<List<string>> GetPlaylistWithLeastTracks(){
        return await _context;
    }
    async Task<List<string>> GetTopFivePlaylistsWithMostTracks(){
        return await _context;
    }
    async Task<List<string>> GetBottomFivePlaylistsWithLeastTracks(){
        return await _context;
    }

}