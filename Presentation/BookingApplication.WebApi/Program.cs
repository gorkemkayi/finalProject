using BookingApplication.Application.Features.CQRS.Handlers.AirlineHandlers;
using BookingApplication.Application.Features.CQRS.Handlers.AirportHandlers;
using BookingApplication.Application.Features.CQRS.Handlers.CurrencyHandlers;
using BookingApplication.Application.Features.CQRS.Handlers.FlightHandlers;
using BookingApplication.Application.Features.CQRS.Handlers.FlightTypeHandlers;
using BookingApplication.Application.Features.CQRS.Handlers.HotelHandlers;
using BookingApplication.Application.Interfaces.BlogInterfaces;
using BookingApplication.Application.Interfaces.FlightInterfaces;
using BookingApplication.Application.Interfaces.Hotelinterfaces;
using BookingApplication.Application.Interfaces.TourInterfaces;
using BookingApplication.Application.Interfaces;
using BookingApplication.Application.Services;
using BookingApplication.Persistence.Repositories.BlogRepositories;
using BookingApplication.Persistence.Repositories.FlightRepositories;
using BookingApplication.Persistence.Repositories.HotelRepositories;
using BookingApplication.Persistence.Repositories.TourRepositories;
using BookingApplication.Persistence.Repositories;
using BookingApplication.Persistence.Context;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using BookingApplication.Application.Tools;
using Microsoft.AspNetCore.Builder;
using BookingApplication.Application.Interfaces.LocationInterfaces;
using BookingApplication.Persistence.Repositories.LocationRepositories;
using BookingApplication.Application.Interfaces.HotelRoomInterfaces;
using BookingApplication.Persistence.Repositories.HotelRoomRepositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.RequireHttpsMetadata = false;
    opt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidAudience = JwtTokenDefaults.ValidAudience,
        ValidIssuer = JwtTokenDefaults.ValidIssuer,
        ClockSkew = TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key)),
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true
    };
});

// Add services to the container.

builder.Services.AddScoped<BookingApplicationContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IHotelRepository), typeof(HotelRepository));
builder.Services.AddScoped(typeof(IFlightRepository), typeof(FlightRepository));
builder.Services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
builder.Services.AddScoped(typeof(ITourRepository), typeof(TourRepository));
builder.Services.AddScoped(typeof(ILocationRepository), typeof(LocationRepository));
builder.Services.AddScoped(typeof(IHotelRoomRepository), typeof(HotelRoomRepository));

builder.Services.AddScoped<GetHotelQueryHandler>();
builder.Services.AddScoped<GetHotelByIdQueryHandler>();
builder.Services.AddScoped<CreateHotelCommandHandler>();
builder.Services.AddScoped<UpdateHotelCommandHandler>();
builder.Services.AddScoped<RemoveHotelCommandHandler>();
builder.Services.AddScoped<Get5HotelQueryHandler>();

builder.Services.AddScoped<CreateCurrencyCommandhandler>();
builder.Services.AddScoped<GetCurrencyByIdQueryHandler>();
builder.Services.AddScoped<GetCurrencyQueryHandler>();
builder.Services.AddScoped<RemoveCurrencyCommandHandler>();
builder.Services.AddScoped<UpdateCurrencyCommandHandler>();

builder.Services.AddScoped<CreateAirlineCommandHandler>();
builder.Services.AddScoped<GetAirlineByIdQueryHandler>();
builder.Services.AddScoped<GetAirlineQueryHandler>();
builder.Services.AddScoped<RemoveAirlineCommandHandler>();
builder.Services.AddScoped<UpdateAirlineCommandHandler>();

builder.Services.AddScoped<CreateAirportCommandHandler>();
builder.Services.AddScoped<GetAirportByIdQueryHandler>();
builder.Services.AddScoped<GetAirportQueryHandler>();
builder.Services.AddScoped<RemoveAirportCommandHandler>();
builder.Services.AddScoped<UpdateAirportCommandHandler>();

builder.Services.AddScoped<CreateFlightTypeCommandHandler>();
builder.Services.AddScoped<GetFlightTypeByIdQueryHandler>();
builder.Services.AddScoped<GetFlightTypeQueryHandler>();
builder.Services.AddScoped<RemoveFlightTypeCommandHandler>();
builder.Services.AddScoped<UpdateFlightTypeCommandHandler>();

builder.Services.AddScoped<CreateFlightCommandHandler>();
builder.Services.AddScoped<GetFlightByIdQueryHandler>();
builder.Services.AddScoped<GetFlightQueryHandler>();
builder.Services.AddScoped<RemoveFlightCommandHandler>();
builder.Services.AddScoped<UpdateFlightCommandHandler>();
builder.Services.AddScoped<GetFeaturedFlightsQueryHandler>();

builder.Services.AddApplicationService(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();


app.Run();
