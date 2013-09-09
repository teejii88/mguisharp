﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MGUI
{
	public class API
	{
		// --------------------------------------------------
		// Library initialization and processing
		// --------------------------------------------------

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_initialize( IntPtr wndhandle, uint parameters );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_shutdown();

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_process();

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_force_redraw();

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_set_renderer( ref IRenderer renderer );

		[DllImport( "mgui.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_set_skin( string skinimg );


		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern IntPtr mgui_get_focus();

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_set_focus( IntPtr element );

		// --------------------------------------------------
		// Child/parent relations
		// --------------------------------------------------

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_add_child( IntPtr parent, IntPtr child );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_remove_child( IntPtr child );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_move_forward( IntPtr child );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_move_backward( IntPtr child );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_send_to_top( IntPtr child );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_send_to_bottom( IntPtr child );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern bool mgui_is_child_of( IntPtr parent, IntPtr child );

		// --------------------------------------------------
		// Element constructors
		// --------------------------------------------------

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern IntPtr mgui_create_button( IntPtr parent );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern IntPtr mgui_create_button_ex( IntPtr parent, short x, short y, ushort w, ushort h, uint flags, uint col, string text );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern IntPtr mgui_create_canvas( IntPtr parent );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern IntPtr mgui_create_editbox( IntPtr parent );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern IntPtr mgui_create_editbox_ex( IntPtr parent, short x, short y, ushort w, ushort h, uint flags, uint col, string text );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern IntPtr mgui_create_label( IntPtr parent );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern IntPtr mgui_create_label_ex( IntPtr parent, short x, short y, ushort w, ushort h, uint flags, uint col, string text );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern IntPtr mgui_create_memobox( IntPtr parent );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern IntPtr mgui_create_memobox_ex( IntPtr parent, short x, short y, ushort w, ushort h, uint flags, uint col );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern IntPtr mgui_create_window( IntPtr parent );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern IntPtr mgui_create_window_ex( IntPtr parent, short x, short y, ushort w, ushort h, uint flags, uint col, string text );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_element_destroy( IntPtr element );

		// --------------------------------------------------
		// Generic element functions
		// --------------------------------------------------

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_get_pos( IntPtr element, out Math.Vector2 pos );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_get_size( IntPtr element, out Math.Vector2 size );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_set_pos( IntPtr element, ref Math.Vector2 pos );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_set_size( IntPtr element, ref Math.Vector2 size );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_get_abs_pos( IntPtr element, out Math.VectorScreen pos );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_get_abs_size( IntPtr element, out Math.VectorScreen size );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_set_abs_pos( IntPtr element, ref Math.VectorScreen pos );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_set_abs_size( IntPtr element, ref Math.VectorScreen size );


		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern float mgui_get_z_depth( IntPtr element );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_set_z_depth( IntPtr element, float depth );


		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_get_colour( IntPtr element, out Math.Colour col );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_set_colour( IntPtr element, ref Math.Colour col );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_get_text_colour( IntPtr element, out Math.Colour col );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_set_text_colour( IntPtr element, ref Math.Colour col );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern byte mgui_get_alpha( IntPtr element );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_set_alpha( IntPtr element, byte alpha );


		[DllImport( "mgui.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl )]
		public static extern IntPtr mgui_get_text( IntPtr element );

		[DllImport( "mgui.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_set_text_s( IntPtr element, string text );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern uint mgui_get_text_len( IntPtr element );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_get_text_size( IntPtr element, out Math.VectorScreen size );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern uint mgui_get_alignment( IntPtr element );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_set_alignment( IntPtr element, uint alignment );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_get_text_padding( IntPtr element, out byte top, out byte bottom, out byte left, out byte right );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_set_text_padding( IntPtr element, byte top, byte bottom, byte left, byte right );


		[DllImport( "mgui.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl )]
		public static extern IntPtr mgui_get_font_name( IntPtr element );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern byte mgui_get_font_size( IntPtr element );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern byte mgui_get_font_flags( IntPtr element );

		[DllImport( "mgui.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_set_font_name( IntPtr element, string font );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_set_font_size( IntPtr element, byte size );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_set_font_flags( IntPtr element, byte flags );

		[DllImport( "mgui.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_set_font( IntPtr element, string font, byte size, byte flags, byte charset );


		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern uint mgui_get_flags( IntPtr element );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern uint mgui_add_flags( IntPtr element, uint flags );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern uint mgui_remove_flags( IntPtr element, uint flags );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_set_event_handler( IntPtr element, Element.GuiEventHandler handler, IntPtr data );

		// --------------------------------------------------
		// Editbox functions
		// --------------------------------------------------

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern bool mgui_editbox_has_text_selected( IntPtr editbox );

		//[DllImport( "mgui.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl )]
		//public static extern void mgui_editbox_get_selection( IntPtr editbox, string buf, uint buflen );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_editbox_select_text( IntPtr editbox, uint begin, uint end );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern uint mgui_editbox_get_cursor_pos( IntPtr editbox );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_editbox_set_cursor_pos( IntPtr editbox, uint pos );

		// --------------------------------------------------
		// Label functions
		// --------------------------------------------------

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_label_make_text_fit( IntPtr label );

		// --------------------------------------------------
		// Memobox functions
		// --------------------------------------------------

		[DllImport( "mgui.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_memobox_add_line_s( IntPtr memobox, string text );

		[DllImport( "mgui.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_memobox_add_line_col_s( IntPtr memobox, string text, ref Math.Colour col );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_memobox_clear( IntPtr memobox );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern float mgui_memobox_get_display_pos( IntPtr memobox );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_memobox_set_display_pos( IntPtr memobox, float pos );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern uint mgui_memobox_get_lines( IntPtr memobox );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_memobox_set_lines( IntPtr memobox, uint lines );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern uint mgui_memobox_get_num_lines( IntPtr memobox );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern uint mgui_memobox_get_history( IntPtr memobox );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_memobox_set_history( IntPtr memobox, uint lines );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern uint mgui_memobox_get_margin( IntPtr memobox );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_memobox_set_margin( IntPtr memobox, uint margin );

		// --------------------------------------------------
		// Window functions
		// --------------------------------------------------

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_window_get_title_col( IntPtr window, out Math.Colour col );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_window_set_title_col( IntPtr window, ref Math.Colour col );

		[DllImport( "mgui.dll", CallingConvention = CallingConvention.Cdecl )]
		public static extern void mgui_window_get_drag_offset( IntPtr window, out Math.VectorScreen pos );
	}
}
