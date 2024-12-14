using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001389 RID: 5001
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TravelBrochureSetCustomValueScRsp : IMessage<TravelBrochureSetCustomValueScRsp>, IMessage, IEquatable<TravelBrochureSetCustomValueScRsp>, IDeepCloneable<TravelBrochureSetCustomValueScRsp>, IBufferMessage
	{
		// Token: 0x17003EA5 RID: 16037
		// (get) Token: 0x0600DF19 RID: 57113 RVA: 0x00251A2C File Offset: 0x0024FC2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TravelBrochureSetCustomValueScRsp> Parser
		{
			get
			{
				return TravelBrochureSetCustomValueScRsp._parser;
			}
		}

		// Token: 0x17003EA6 RID: 16038
		// (get) Token: 0x0600DF1A RID: 57114 RVA: 0x00251A33 File Offset: 0x0024FC33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TravelBrochureSetCustomValueScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003EA7 RID: 16039
		// (get) Token: 0x0600DF1B RID: 57115 RVA: 0x00251A45 File Offset: 0x0024FC45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TravelBrochureSetCustomValueScRsp.Descriptor;
			}
		}

		// Token: 0x0600DF1C RID: 57116 RVA: 0x00251A4C File Offset: 0x0024FC4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureSetCustomValueScRsp()
		{
		}

		// Token: 0x0600DF1D RID: 57117 RVA: 0x00251A54 File Offset: 0x0024FC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureSetCustomValueScRsp(TravelBrochureSetCustomValueScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF1E RID: 57118 RVA: 0x00251A79 File Offset: 0x0024FC79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TravelBrochureSetCustomValueScRsp Clone()
		{
			return new TravelBrochureSetCustomValueScRsp(this);
		}

		// Token: 0x17003EA8 RID: 16040
		// (get) Token: 0x0600DF1F RID: 57119 RVA: 0x00251A81 File Offset: 0x0024FC81
		// (set) Token: 0x0600DF20 RID: 57120 RVA: 0x00251A89 File Offset: 0x0024FC89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x0600DF21 RID: 57121 RVA: 0x00251A92 File Offset: 0x0024FC92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TravelBrochureSetCustomValueScRsp);
		}

		// Token: 0x0600DF22 RID: 57122 RVA: 0x00251AA0 File Offset: 0x0024FCA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TravelBrochureSetCustomValueScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF23 RID: 57123 RVA: 0x00251AD0 File Offset: 0x0024FCD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DF24 RID: 57124 RVA: 0x00251B0F File Offset: 0x0024FD0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DF25 RID: 57125 RVA: 0x00251B17 File Offset: 0x0024FD17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF26 RID: 57126 RVA: 0x00251B20 File Offset: 0x0024FD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DF27 RID: 57127 RVA: 0x00251B54 File Offset: 0x0024FD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DF28 RID: 57128 RVA: 0x00251B92 File Offset: 0x0024FD92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TravelBrochureSetCustomValueScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DF29 RID: 57129 RVA: 0x00251BC3 File Offset: 0x0024FDC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF2A RID: 57130 RVA: 0x00251BCC File Offset: 0x0024FDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040058A7 RID: 22695
		private static readonly MessageParser<TravelBrochureSetCustomValueScRsp> _parser = new MessageParser<TravelBrochureSetCustomValueScRsp>(() => new TravelBrochureSetCustomValueScRsp());

		// Token: 0x040058A8 RID: 22696
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058A9 RID: 22697
		public const int RetcodeFieldNumber = 13;

		// Token: 0x040058AA RID: 22698
		private uint retcode_;
	}
}
