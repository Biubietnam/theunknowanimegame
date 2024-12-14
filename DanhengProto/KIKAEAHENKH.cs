using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009AF RID: 2479
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KIKAEAHENKH : IMessage<KIKAEAHENKH>, IMessage, IEquatable<KIKAEAHENKH>, IDeepCloneable<KIKAEAHENKH>, IBufferMessage
	{
		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x06006EC1 RID: 28353 RVA: 0x00127D39 File Offset: 0x00125F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KIKAEAHENKH> Parser
		{
			get
			{
				return KIKAEAHENKH._parser;
			}
		}

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x06006EC2 RID: 28354 RVA: 0x00127D40 File Offset: 0x00125F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KIKAEAHENKHReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x06006EC3 RID: 28355 RVA: 0x00127D52 File Offset: 0x00125F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KIKAEAHENKH.Descriptor;
			}
		}

		// Token: 0x06006EC4 RID: 28356 RVA: 0x00127D59 File Offset: 0x00125F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KIKAEAHENKH()
		{
		}

		// Token: 0x06006EC5 RID: 28357 RVA: 0x00127D61 File Offset: 0x00125F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KIKAEAHENKH(KIKAEAHENKH other) : this()
		{
			this.pOEDFMELAKE_ = other.pOEDFMELAKE_;
			this.pos_ = other.pos_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006EC6 RID: 28358 RVA: 0x00127D92 File Offset: 0x00125F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KIKAEAHENKH Clone()
		{
			return new KIKAEAHENKH(this);
		}

		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x06006EC7 RID: 28359 RVA: 0x00127D9A File Offset: 0x00125F9A
		// (set) Token: 0x06006EC8 RID: 28360 RVA: 0x00127DA2 File Offset: 0x00125FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint POEDFMELAKE
		{
			get
			{
				return this.pOEDFMELAKE_;
			}
			set
			{
				this.pOEDFMELAKE_ = value;
			}
		}

		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x06006EC9 RID: 28361 RVA: 0x00127DAB File Offset: 0x00125FAB
		// (set) Token: 0x06006ECA RID: 28362 RVA: 0x00127DB3 File Offset: 0x00125FB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DAEALPIOKMG Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x06006ECB RID: 28363 RVA: 0x00127DBC File Offset: 0x00125FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KIKAEAHENKH);
		}

		// Token: 0x06006ECC RID: 28364 RVA: 0x00127DCA File Offset: 0x00125FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KIKAEAHENKH other)
		{
			return other != null && (other == this || (this.POEDFMELAKE == other.POEDFMELAKE && this.Pos == other.Pos && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006ECD RID: 28365 RVA: 0x00127E08 File Offset: 0x00126008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.POEDFMELAKE != 0U)
			{
				num ^= this.POEDFMELAKE.GetHashCode();
			}
			if (this.Pos != DAEALPIOKMG.WorkPosNone)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006ECE RID: 28366 RVA: 0x00127E66 File Offset: 0x00126066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006ECF RID: 28367 RVA: 0x00127E6E File Offset: 0x0012606E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006ED0 RID: 28368 RVA: 0x00127E78 File Offset: 0x00126078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Pos != DAEALPIOKMG.WorkPosNone)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Pos);
			}
			if (this.POEDFMELAKE != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.POEDFMELAKE);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006ED1 RID: 28369 RVA: 0x00127ED4 File Offset: 0x001260D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.POEDFMELAKE != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.POEDFMELAKE);
			}
			if (this.Pos != DAEALPIOKMG.WorkPosNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Pos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006ED2 RID: 28370 RVA: 0x00127F2C File Offset: 0x0012612C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KIKAEAHENKH other)
		{
			if (other == null)
			{
				return;
			}
			if (other.POEDFMELAKE != 0U)
			{
				this.POEDFMELAKE = other.POEDFMELAKE;
			}
			if (other.Pos != DAEALPIOKMG.WorkPosNone)
			{
				this.Pos = other.Pos;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006ED3 RID: 28371 RVA: 0x00127F7C File Offset: 0x0012617C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006ED4 RID: 28372 RVA: 0x00127F88 File Offset: 0x00126188
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.POEDFMELAKE = input.ReadUInt32();
					}
				}
				else
				{
					this.Pos = (DAEALPIOKMG)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002A8C RID: 10892
		private static readonly MessageParser<KIKAEAHENKH> _parser = new MessageParser<KIKAEAHENKH>(() => new KIKAEAHENKH());

		// Token: 0x04002A8D RID: 10893
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A8E RID: 10894
		public const int POEDFMELAKEFieldNumber = 11;

		// Token: 0x04002A8F RID: 10895
		private uint pOEDFMELAKE_;

		// Token: 0x04002A90 RID: 10896
		public const int PosFieldNumber = 5;

		// Token: 0x04002A91 RID: 10897
		private DAEALPIOKMG pos_;
	}
}
