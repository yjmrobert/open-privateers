'use strict';

/**
 * ship service
 */

const { createCoreService } = require('@strapi/strapi').factories;

module.exports = createCoreService('api::ship.ship');
