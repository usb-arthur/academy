<template>
    <div class="container-fluid">
        <b-container class="bv-example-row full-height" fluid>
            <b-row class="container-fluid" align-h="center">
                <b-col>
                    <h3>ABC ACADEMY</h3>
                </b-col>
                <b-col>
                    <md-menu md-direction="bottom-start">
                        <md-button md-menu-trigger>Lĩnh vực</md-button>

                        <md-menu-content>
                            <md-menu-item v-for="item in dslinhvucs" :key="item.id">{{item.catalogname}}</md-menu-item>
                        </md-menu-content>
                    </md-menu>
                </b-col>
                <b-col>
                    <b-input-group>
      <b-input-group-prepend >
          <b-button variant="outline-secondary bg-white">
            <md-icon>search</md-icon>
          </b-button>
      </b-input-group-prepend>
    <b-form-input></b-form-input>
  </b-input-group>
                </b-col>
                <b-col>
                    PLACE HOLDER
                </b-col>
                <b-col>
                    PLACE HOLDER
                </b-col>
            </b-row>
        </b-container>




    </div>
</template>

<script>
    export default {
        components: {},
        computed: {
            dslinhvucs() {
                console.log(this.$store);
                return this.$store.getters["linhvuc/ACatalog"];
            },
        }
    }
</script>