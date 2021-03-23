var Discord = require('discord.js')

exports.run = async(client, msg, args) => {
    var supportRole = msg.guild.roles.cache.find(r => r.name === "Support")
    var staffRole = msg.guild.roles.cache.find(r => r.name === "Staff")
    var adminRole = msg.guild.roles.cache.find(r => r.name === "Administrator")

    if(msg.channel.name.includes("general-") || msg.channel.name.includes("bugs-") || msg.channel.name.includes("donations-") || msg.channel.name.includes("report-")) {

    if(msg.member.roles.cache.has(supportRole.id) || msg.member.hasPermission("MANAGE_SERVER")) {
        if(msg.content.includes("-s")) {

            msg.channel.updateOverwrite(adminRole, {
                SEND_MESSAGES: false,
                VIEW_CHANNEL: false,
                READ_MESSAGE_HISTORY: false
               })

               msg.channel.updateOverwrite(supportRole, {
                SEND_MESSAGES: false,
                VIEW_CHANNEL: false,
                READ_MESSAGE_HISTORY: false
               })

            msg.channel.send(`**${msg.member}** has changed **${msg.channel}** to **Management** discretion.`)
        } else {

            msg.channel.updateOverwrite(adminRole, {
                SEND_MESSAGES: false,
                VIEW_CHANNEL: false,
                READ_MESSAGE_HISTORY: false
               })

               msg.channel.updateOverwrite(supportRole, {
                SEND_MESSAGES: false,
                VIEW_CHANNEL: false,
                READ_MESSAGE_HISTORY: false
               })
          msg.channel.send(`**${msg.member}** has changed **${msg.channel}** to **Management** discretion. ${staffRole}`)
    }
    } else {
        msg.reply("You do not have permission to use this command!")
    }
} else {
    msg.reply("You may only use this command in a ticket!")
}
}