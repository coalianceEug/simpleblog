//def ReleaseDir = "F:\MyProjects\SimpleBlogAPIHost"
pipeline {
			agent any
			stages {
				stage('Source'){
					steps{
						checkout([$class: 'GitSCM', branches: [[name: '*/master']], doGenerateSubmoduleConfigurations: false, extensions: [], submoduleCfg: [], userRemoteConfigs: [[credentialsId: 'ed43b981-6118-4d36-8c8a-c5810a9fdd8d', url: 'https://github.com/coalianceEug/simpleblog.git']]])
					}
				}
				stage('Build') {
    					steps {
    					    bat "\"${tool 'MSBuild'}\" SimpleBlog.sln /p:DeployOnBuild=true /p:DeployDefaultTarget=WebPublish /p:WebPublishMethod=FileSystem /p:SkipInvalidConfigurations=true /t:build /p:Configuration=Release /p:Platform=\"Any CPU\" /p:DeleteExistingFiles=True /p:publishUrl=F:\\MyProjects\\SimpleBlogAPIHost"
    					}
				}
			}
}