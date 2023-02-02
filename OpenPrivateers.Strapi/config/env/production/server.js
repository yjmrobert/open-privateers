module.exports = ({ env }) => ({
    host: env("HOST", "0.0.0.0"),
    port: env.int("PORT", 1337),
    url: "https://open-privateers-api.azurewebsites.net",
    admin: {
      url: "https://proud-forest-0bfb17710.2.azurestaticapps.net/",
      serveAdminPanel: false,
    },
  });