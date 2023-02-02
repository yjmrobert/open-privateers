'use strict';

/**
 * weapon service
 */

const { createCoreService } = require('@strapi/strapi').factories;

module.exports = createCoreService('api::weapon.weapon');
