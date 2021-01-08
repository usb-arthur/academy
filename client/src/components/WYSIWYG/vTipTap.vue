<template>
  <tiptap-vuetify
    class="text-left"
    v-model="content"
    :extensions="extensions"
    placeholder="Mô tả chi tiết"
  />
</template>

<script>
import {
  TiptapVuetify,
  Heading,
  Bold,
  Italic,
  Strike,
  Underline,
  Code,
  Paragraph,
  BulletList,
  OrderedList,
  ListItem,
  Link,
  Blockquote,
  HardBreak,
  HorizontalRule,
  History
} from "tiptap-vuetify";

export default {
  components: { TiptapVuetify },
  props: {
    value: String
  },
  watch: {
    content(value) {
      this.$emit("input", value);
    }
  },
  data: () => ({
    // declare extensions you want to use
    extensions: [
      History,
      Blockquote,
      Link,
      Underline,
      Strike,
      Italic,
      ListItem,
      BulletList,
      OrderedList,
      [
        Heading,
        {
          options: {
            levels: [1, 2, 3]
          }
        }
      ],
      Bold,
      Code,
      HorizontalRule,
      Paragraph,
      HardBreak
    ],
    content: ""
  }),
  created() {
    this.content = this.value;
  }
};
</script>
