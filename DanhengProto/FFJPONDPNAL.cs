using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200051D RID: 1309
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FFJPONDPNAL : IMessage<FFJPONDPNAL>, IMessage, IEquatable<FFJPONDPNAL>, IDeepCloneable<FFJPONDPNAL>, IBufferMessage
	{
		// Token: 0x170010B5 RID: 4277
		// (get) Token: 0x06003A83 RID: 14979 RVA: 0x000A0F00 File Offset: 0x0009F100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FFJPONDPNAL> Parser
		{
			get
			{
				return FFJPONDPNAL._parser;
			}
		}

		// Token: 0x170010B6 RID: 4278
		// (get) Token: 0x06003A84 RID: 14980 RVA: 0x000A0F07 File Offset: 0x0009F107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FFJPONDPNALReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170010B7 RID: 4279
		// (get) Token: 0x06003A85 RID: 14981 RVA: 0x000A0F19 File Offset: 0x0009F119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FFJPONDPNAL.Descriptor;
			}
		}

		// Token: 0x06003A86 RID: 14982 RVA: 0x000A0F20 File Offset: 0x0009F120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FFJPONDPNAL()
		{
		}

		// Token: 0x06003A87 RID: 14983 RVA: 0x000A0F28 File Offset: 0x0009F128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FFJPONDPNAL(FFJPONDPNAL other) : this()
		{
			this.cGAAJPDAFMG_ = other.cGAAJPDAFMG_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003A88 RID: 14984 RVA: 0x000A0F4D File Offset: 0x0009F14D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FFJPONDPNAL Clone()
		{
			return new FFJPONDPNAL(this);
		}

		// Token: 0x170010B8 RID: 4280
		// (get) Token: 0x06003A89 RID: 14985 RVA: 0x000A0F55 File Offset: 0x0009F155
		// (set) Token: 0x06003A8A RID: 14986 RVA: 0x000A0F5D File Offset: 0x0009F15D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint CGAAJPDAFMG
		{
			get
			{
				return this.cGAAJPDAFMG_;
			}
			set
			{
				this.cGAAJPDAFMG_ = value;
			}
		}

		// Token: 0x06003A8B RID: 14987 RVA: 0x000A0F66 File Offset: 0x0009F166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FFJPONDPNAL);
		}

		// Token: 0x06003A8C RID: 14988 RVA: 0x000A0F74 File Offset: 0x0009F174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FFJPONDPNAL other)
		{
			return other != null && (other == this || (this.CGAAJPDAFMG == other.CGAAJPDAFMG && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003A8D RID: 14989 RVA: 0x000A0FA4 File Offset: 0x0009F1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CGAAJPDAFMG != 0U)
			{
				num ^= this.CGAAJPDAFMG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003A8E RID: 14990 RVA: 0x000A0FE3 File Offset: 0x0009F1E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x000A0FEB File Offset: 0x0009F1EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x000A0FF4 File Offset: 0x0009F1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CGAAJPDAFMG != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.CGAAJPDAFMG);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x000A1028 File Offset: 0x0009F228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CGAAJPDAFMG != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.CGAAJPDAFMG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x000A1066 File Offset: 0x0009F266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FFJPONDPNAL other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CGAAJPDAFMG != 0U)
			{
				this.CGAAJPDAFMG = other.CGAAJPDAFMG;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003A93 RID: 14995 RVA: 0x000A1097 File Offset: 0x0009F297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003A94 RID: 14996 RVA: 0x000A10A0 File Offset: 0x0009F2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CGAAJPDAFMG = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001788 RID: 6024
		private static readonly MessageParser<FFJPONDPNAL> _parser = new MessageParser<FFJPONDPNAL>(() => new FFJPONDPNAL());

		// Token: 0x04001789 RID: 6025
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400178A RID: 6026
		public const int CGAAJPDAFMGFieldNumber = 4;

		// Token: 0x0400178B RID: 6027
		private uint cGAAJPDAFMG_;
	}
}
