using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E97 RID: 3735
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueGetGambleInfoScRsp : IMessage<RogueGetGambleInfoScRsp>, IMessage, IEquatable<RogueGetGambleInfoScRsp>, IDeepCloneable<RogueGetGambleInfoScRsp>, IBufferMessage
	{
		// Token: 0x17002F24 RID: 12068
		// (get) Token: 0x0600A6DC RID: 42716 RVA: 0x001C1745 File Offset: 0x001BF945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueGetGambleInfoScRsp> Parser
		{
			get
			{
				return RogueGetGambleInfoScRsp._parser;
			}
		}

		// Token: 0x17002F25 RID: 12069
		// (get) Token: 0x0600A6DD RID: 42717 RVA: 0x001C174C File Offset: 0x001BF94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueGetGambleInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F26 RID: 12070
		// (get) Token: 0x0600A6DE RID: 42718 RVA: 0x001C175E File Offset: 0x001BF95E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueGetGambleInfoScRsp.Descriptor;
			}
		}

		// Token: 0x0600A6DF RID: 42719 RVA: 0x001C1765 File Offset: 0x001BF965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGetGambleInfoScRsp()
		{
		}

		// Token: 0x0600A6E0 RID: 42720 RVA: 0x001C1770 File Offset: 0x001BF970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGetGambleInfoScRsp(RogueGetGambleInfoScRsp other) : this()
		{
			this.gambleInfo_ = ((other.gambleInfo_ != null) ? other.gambleInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A6E1 RID: 42721 RVA: 0x001C17BC File Offset: 0x001BF9BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGetGambleInfoScRsp Clone()
		{
			return new RogueGetGambleInfoScRsp(this);
		}

		// Token: 0x17002F27 RID: 12071
		// (get) Token: 0x0600A6E2 RID: 42722 RVA: 0x001C17C4 File Offset: 0x001BF9C4
		// (set) Token: 0x0600A6E3 RID: 42723 RVA: 0x001C17CC File Offset: 0x001BF9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueGambleInfo GambleInfo
		{
			get
			{
				return this.gambleInfo_;
			}
			set
			{
				this.gambleInfo_ = value;
			}
		}

		// Token: 0x17002F28 RID: 12072
		// (get) Token: 0x0600A6E4 RID: 42724 RVA: 0x001C17D5 File Offset: 0x001BF9D5
		// (set) Token: 0x0600A6E5 RID: 42725 RVA: 0x001C17DD File Offset: 0x001BF9DD
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

		// Token: 0x0600A6E6 RID: 42726 RVA: 0x001C17E6 File Offset: 0x001BF9E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueGetGambleInfoScRsp);
		}

		// Token: 0x0600A6E7 RID: 42727 RVA: 0x001C17F4 File Offset: 0x001BF9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueGetGambleInfoScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.GambleInfo, other.GambleInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A6E8 RID: 42728 RVA: 0x001C1844 File Offset: 0x001BFA44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.gambleInfo_ != null)
			{
				num ^= this.GambleInfo.GetHashCode();
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

		// Token: 0x0600A6E9 RID: 42729 RVA: 0x001C1899 File Offset: 0x001BFA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A6EA RID: 42730 RVA: 0x001C18A1 File Offset: 0x001BFAA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A6EB RID: 42731 RVA: 0x001C18AC File Offset: 0x001BFAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.gambleInfo_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.GambleInfo);
			}
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

		// Token: 0x0600A6EC RID: 42732 RVA: 0x001C1908 File Offset: 0x001BFB08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.gambleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GambleInfo);
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

		// Token: 0x0600A6ED RID: 42733 RVA: 0x001C1960 File Offset: 0x001BFB60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueGetGambleInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.gambleInfo_ != null)
			{
				if (this.gambleInfo_ == null)
				{
					this.GambleInfo = new RogueGambleInfo();
				}
				this.GambleInfo.MergeFrom(other.GambleInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A6EE RID: 42734 RVA: 0x001C19C8 File Offset: 0x001BFBC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A6EF RID: 42735 RVA: 0x001C19D4 File Offset: 0x001BFBD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 82U)
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
				else
				{
					if (this.gambleInfo_ == null)
					{
						this.GambleInfo = new RogueGambleInfo();
					}
					input.ReadMessage(this.GambleInfo);
				}
			}
		}

		// Token: 0x04004441 RID: 17473
		private static readonly MessageParser<RogueGetGambleInfoScRsp> _parser = new MessageParser<RogueGetGambleInfoScRsp>(() => new RogueGetGambleInfoScRsp());

		// Token: 0x04004442 RID: 17474
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004443 RID: 17475
		public const int GambleInfoFieldNumber = 10;

		// Token: 0x04004444 RID: 17476
		private RogueGambleInfo gambleInfo_;

		// Token: 0x04004445 RID: 17477
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04004446 RID: 17478
		private uint retcode_;
	}
}
