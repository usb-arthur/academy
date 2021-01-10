<template>
  <v-container class="text-left">
    <v-card-title style="font-size: 40px" class="mb-4">
      Danh sách khóa học
    </v-card-title>
    <v-item-group>
      <v-container>
        <v-row>
          <v-col
              v-for="n in 9"
              :key="n"
              cols="12"
              md="4"
          >
            <v-card>
              <v-img
                  src="https://picsum.photos/350/165?random"
                  height="125"
                  class="grey darken-4"
              ></v-img>
              <v-card-title class="title">
                Wireshark: Packet Analysis and Ethical Hacking
                <div>
                  <span style="font-size: 15px;color: #00000096;">aaa</span>
                  <v-rating
                      :value="rate"
                      color="amber"
                      dense
                      half-increments
                      readonly
                      size="14"
                  ></v-rating>
                  <span><span>19.99</span>Đ</span>
                  <div class="row mt-1">
                    <v-chip
                        class="ma-2"
                        color="orange"
                        text-color="white"
                    >
                      Đang giảm giá
                    </v-chip>

                    <v-chip
                        class="ma-2"
                        color="primary"
                        text-color="white"
                    >
                      Mới
                    </v-chip>

                  </div>
                </div>
              </v-card-title>
            </v-card>
          </v-col>
        </v-row>
      </v-container>
    </v-item-group>
    <div class="text-center mt-6">
      <v-pagination
          v-model="page"
          :length="6"
      ></v-pagination>
    </div>
  </v-container>
</template>

<script>

export default {
  data: () => ({

  }),
  updated() {},
  watch: {

  },
  computed: {

  },
  created() {

  },
  methods: {

  }
};
</script>

<style>

</style>
