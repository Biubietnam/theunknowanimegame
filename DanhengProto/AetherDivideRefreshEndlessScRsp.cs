using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200005D RID: 93
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AetherDivideRefreshEndlessScRsp : IMessage<AetherDivideRefreshEndlessScRsp>, IMessage, IEquatable<AetherDivideRefreshEndlessScRsp>, IDeepCloneable<AetherDivideRefreshEndlessScRsp>, IBufferMessage
	{
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0000BABD File Offset: 0x00009CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AetherDivideRefreshEndlessScRsp> Parser
		{
			get
			{
				return AetherDivideRefreshEndlessScRsp._parser;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x0000BAC4 File Offset: 0x00009CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AetherDivideRefreshEndlessScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x0000BAD6 File Offset: 0x00009CD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AetherDivideRefreshEndlessScRsp.Descriptor;
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000BADD File Offset: 0x00009CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideRefreshEndlessScRsp()
		{
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000BAE5 File Offset: 0x00009CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideRefreshEndlessScRsp(AetherDivideRefreshEndlessScRsp other) : this()
		{
			this.pHPCDGEMAGD_ = other.pHPCDGEMAGD_;
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000BB16 File Offset: 0x00009D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideRefreshEndlessScRsp Clone()
		{
			return new AetherDivideRefreshEndlessScRsp(this);
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x0000BB1E File Offset: 0x00009D1E
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x0000BB26 File Offset: 0x00009D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PHPCDGEMAGD
		{
			get
			{
				return this.pHPCDGEMAGD_;
			}
			set
			{
				this.pHPCDGEMAGD_ = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0000BB2F File Offset: 0x00009D2F
		// (set) Token: 0x060003DB RID: 987 RVA: 0x0000BB37 File Offset: 0x00009D37
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

		// Token: 0x060003DC RID: 988 RVA: 0x0000BB40 File Offset: 0x00009D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AetherDivideRefreshEndlessScRsp);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000BB4E File Offset: 0x00009D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AetherDivideRefreshEndlessScRsp other)
		{
			return other != null && (other == this || (this.PHPCDGEMAGD == other.PHPCDGEMAGD && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000BB8C File Offset: 0x00009D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PHPCDGEMAGD != 0U)
			{
				num ^= this.PHPCDGEMAGD.GetHashCode();
			}
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

		// Token: 0x060003DF RID: 991 RVA: 0x0000BBE4 File Offset: 0x00009DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000BBEC File Offset: 0x00009DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PHPCDGEMAGD != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.PHPCDGEMAGD);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000BC54 File Offset: 0x00009E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PHPCDGEMAGD != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PHPCDGEMAGD);
			}
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

		// Token: 0x060003E3 RID: 995 RVA: 0x0000BCAC File Offset: 0x00009EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AetherDivideRefreshEndlessScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PHPCDGEMAGD != 0U)
			{
				this.PHPCDGEMAGD = other.PHPCDGEMAGD;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000BCFC File Offset: 0x00009EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000BD08 File Offset: 0x00009F08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					this.PHPCDGEMAGD = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400016C RID: 364
		private static readonly MessageParser<AetherDivideRefreshEndlessScRsp> _parser = new MessageParser<AetherDivideRefreshEndlessScRsp>(() => new AetherDivideRefreshEndlessScRsp());

		// Token: 0x0400016D RID: 365
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400016E RID: 366
		public const int PHPCDGEMAGDFieldNumber = 2;

		// Token: 0x0400016F RID: 367
		private uint pHPCDGEMAGD_;

		// Token: 0x04000170 RID: 368
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04000171 RID: 369
		private uint retcode_;
	}
}
