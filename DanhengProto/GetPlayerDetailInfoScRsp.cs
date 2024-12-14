using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200076B RID: 1899
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetPlayerDetailInfoScRsp : IMessage<GetPlayerDetailInfoScRsp>, IMessage, IEquatable<GetPlayerDetailInfoScRsp>, IDeepCloneable<GetPlayerDetailInfoScRsp>, IBufferMessage
	{
		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x060054DA RID: 21722 RVA: 0x000E41EF File Offset: 0x000E23EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetPlayerDetailInfoScRsp> Parser
		{
			get
			{
				return GetPlayerDetailInfoScRsp._parser;
			}
		}

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x060054DB RID: 21723 RVA: 0x000E41F6 File Offset: 0x000E23F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetPlayerDetailInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x060054DC RID: 21724 RVA: 0x000E4208 File Offset: 0x000E2408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetPlayerDetailInfoScRsp.Descriptor;
			}
		}

		// Token: 0x060054DD RID: 21725 RVA: 0x000E420F File Offset: 0x000E240F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerDetailInfoScRsp()
		{
		}

		// Token: 0x060054DE RID: 21726 RVA: 0x000E4218 File Offset: 0x000E2418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerDetailInfoScRsp(GetPlayerDetailInfoScRsp other) : this()
		{
			this.detailInfo_ = ((other.detailInfo_ != null) ? other.detailInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060054DF RID: 21727 RVA: 0x000E4264 File Offset: 0x000E2464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetPlayerDetailInfoScRsp Clone()
		{
			return new GetPlayerDetailInfoScRsp(this);
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x060054E0 RID: 21728 RVA: 0x000E426C File Offset: 0x000E246C
		// (set) Token: 0x060054E1 RID: 21729 RVA: 0x000E4274 File Offset: 0x000E2474
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerDetailInfo DetailInfo
		{
			get
			{
				return this.detailInfo_;
			}
			set
			{
				this.detailInfo_ = value;
			}
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x060054E2 RID: 21730 RVA: 0x000E427D File Offset: 0x000E247D
		// (set) Token: 0x060054E3 RID: 21731 RVA: 0x000E4285 File Offset: 0x000E2485
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

		// Token: 0x060054E4 RID: 21732 RVA: 0x000E428E File Offset: 0x000E248E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetPlayerDetailInfoScRsp);
		}

		// Token: 0x060054E5 RID: 21733 RVA: 0x000E429C File Offset: 0x000E249C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetPlayerDetailInfoScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.DetailInfo, other.DetailInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060054E6 RID: 21734 RVA: 0x000E42EC File Offset: 0x000E24EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.detailInfo_ != null)
			{
				num ^= this.DetailInfo.GetHashCode();
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

		// Token: 0x060054E7 RID: 21735 RVA: 0x000E4341 File Offset: 0x000E2541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060054E8 RID: 21736 RVA: 0x000E4349 File Offset: 0x000E2549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060054E9 RID: 21737 RVA: 0x000E4354 File Offset: 0x000E2554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.detailInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.DetailInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060054EA RID: 21738 RVA: 0x000E43B0 File Offset: 0x000E25B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.detailInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DetailInfo);
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

		// Token: 0x060054EB RID: 21739 RVA: 0x000E4408 File Offset: 0x000E2608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetPlayerDetailInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.detailInfo_ != null)
			{
				if (this.detailInfo_ == null)
				{
					this.DetailInfo = new PlayerDetailInfo();
				}
				this.DetailInfo.MergeFrom(other.DetailInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060054EC RID: 21740 RVA: 0x000E4470 File Offset: 0x000E2670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060054ED RID: 21741 RVA: 0x000E447C File Offset: 0x000E267C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.detailInfo_ == null)
						{
							this.DetailInfo = new PlayerDetailInfo();
						}
						input.ReadMessage(this.DetailInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400214E RID: 8526
		private static readonly MessageParser<GetPlayerDetailInfoScRsp> _parser = new MessageParser<GetPlayerDetailInfoScRsp>(() => new GetPlayerDetailInfoScRsp());

		// Token: 0x0400214F RID: 8527
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002150 RID: 8528
		public const int DetailInfoFieldNumber = 8;

		// Token: 0x04002151 RID: 8529
		private PlayerDetailInfo detailInfo_;

		// Token: 0x04002152 RID: 8530
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04002153 RID: 8531
		private uint retcode_;
	}
}
