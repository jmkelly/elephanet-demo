module.exports = function(grunt) {

  // Project configuration.
  grunt.initConfig({
    pkg: grunt.file.readJSON('package.json'),
    hb: 'bower_components/handlebars/handlebars.runtime.js',
    kernel: 'bower_components/kerneljs/kernel.js',
    modules: 'js/modules/*.js',
    hubs: 'js/hubs/*.js',
    kernels: 'js/kernels/*.js',
    template: 'js/build/templates.js',
    templates: 'js/templates/*.hbs',
    application: 'js/app.js',
    files: ['<%= hb %>','<%= kernel %>','<%= template %>','<%= kernels %>', '<%= hubs %>', '<%= modules %>','<%= application %>'],

    watch: {
      src: {
        files: '<%= files %>',
	tasks: ['build']
      }
    },


    concat: {
      dist: {
        src: '<%= files %>',
	dest: 'Content/<%= pkg.name %>.min.js'
      }
    },
    handlebars: {
      compile : {
        options : {
          namespace: 'Handlebars',
	  processName: function (filePath) {
	    var filename = filePath.replace(/^.*[\\\/]/,'')	  
	    return filename.split('.')[0];
	  }
	},
        files: {
      	  "<%= template %>": ['<%= templates %>']
        }
      }
    }
  });

  grunt.loadNpmTasks('grunt-contrib-concat');
  grunt.loadNpmTasks('grunt-contrib-handlebars');
  grunt.loadNpmTasks('grunt-contrib-watch');

  // Default task(s).
//  grunt.registerTask('default', ['uglify']);
  grunt.registerTask('build', ['handlebars','concat']);

};
