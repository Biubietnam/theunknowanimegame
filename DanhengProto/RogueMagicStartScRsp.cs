using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F21 RID: 3873
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicStartScRsp : IMessage<RogueMagicStartScRsp>, IMessage, IEquatable<RogueMagicStartScRsp>, IDeepCloneable<RogueMagicStartScRsp>, IBufferMessage
	{
		// Token: 0x170030C7 RID: 12487
		// (get) Token: 0x0600ACD0 RID: 44240 RVA: 0x001D10EB File Offset: 0x001CF2EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicStartScRsp> Parser
		{
			get
			{
				return RogueMagicStartScRsp._parser;
			}
		}

		// Token: 0x170030C8 RID: 12488
		// (get) Token: 0x0600ACD1 RID: 44241 RVA: 0x001D10F2 File Offset: 0x001CF2F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicStartScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170030C9 RID: 12489
		// (get) Token: 0x0600ACD2 RID: 44242 RVA: 0x001D1104 File Offset: 0x001CF304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicStartScRsp.Descriptor;
			}
		}

		// Token: 0x0600ACD3 RID: 44243 RVA: 0x001D110B File Offset: 0x001CF30B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicStartScRsp()
		{
		}

		// Token: 0x0600ACD4 RID: 44244 RVA: 0x001D1114 File Offset: 0x001CF314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicStartScRsp(RogueMagicStartScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this.rogueTournCurInfo_ = ((other.rogueTournCurInfo_ != null) ? other.rogueTournCurInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ACD5 RID: 44245 RVA: 0x001D117C File Offset: 0x001CF37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicStartScRsp Clone()
		{
			return new RogueMagicStartScRsp(this);
		}

		// Token: 0x170030CA RID: 12490
		// (get) Token: 0x0600ACD6 RID: 44246 RVA: 0x001D1184 File Offset: 0x001CF384
		// (set) Token: 0x0600ACD7 RID: 44247 RVA: 0x001D118C File Offset: 0x001CF38C
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

		// Token: 0x170030CB RID: 12491
		// (get) Token: 0x0600ACD8 RID: 44248 RVA: 0x001D1195 File Offset: 0x001CF395
		// (set) Token: 0x0600ACD9 RID: 44249 RVA: 0x001D119D File Offset: 0x001CF39D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicCurSceneInfo RogueTournCurSceneInfo
		{
			get
			{
				return this.rogueTournCurSceneInfo_;
			}
			set
			{
				this.rogueTournCurSceneInfo_ = value;
			}
		}

		// Token: 0x170030CC RID: 12492
		// (get) Token: 0x0600ACDA RID: 44250 RVA: 0x001D11A6 File Offset: 0x001CF3A6
		// (set) Token: 0x0600ACDB RID: 44251 RVA: 0x001D11AE File Offset: 0x001CF3AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicCurInfo RogueTournCurInfo
		{
			get
			{
				return this.rogueTournCurInfo_;
			}
			set
			{
				this.rogueTournCurInfo_ = value;
			}
		}

		// Token: 0x0600ACDC RID: 44252 RVA: 0x001D11B7 File Offset: 0x001CF3B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicStartScRsp);
		}

		// Token: 0x0600ACDD RID: 44253 RVA: 0x001D11C8 File Offset: 0x001CF3C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicStartScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && object.Equals(this.RogueTournCurInfo, other.RogueTournCurInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ACDE RID: 44254 RVA: 0x001D122C File Offset: 0x001CF42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num ^= this.RogueTournCurSceneInfo.GetHashCode();
			}
			if (this.rogueTournCurInfo_ != null)
			{
				num ^= this.RogueTournCurInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600ACDF RID: 44255 RVA: 0x001D1297 File Offset: 0x001CF497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600ACE0 RID: 44256 RVA: 0x001D129F File Offset: 0x001CF49F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ACE1 RID: 44257 RVA: 0x001D12A8 File Offset: 0x001CF4A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueTournCurSceneInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RogueTournCurSceneInfo);
			}
			if (this.rogueTournCurInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.RogueTournCurInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(88);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600ACE2 RID: 44258 RVA: 0x001D1320 File Offset: 0x001CF520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurSceneInfo);
			}
			if (this.rogueTournCurInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600ACE3 RID: 44259 RVA: 0x001D1390 File Offset: 0x001CF590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicStartScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.rogueTournCurSceneInfo_ != null)
			{
				if (this.rogueTournCurSceneInfo_ == null)
				{
					this.RogueTournCurSceneInfo = new RogueMagicCurSceneInfo();
				}
				this.RogueTournCurSceneInfo.MergeFrom(other.RogueTournCurSceneInfo);
			}
			if (other.rogueTournCurInfo_ != null)
			{
				if (this.rogueTournCurInfo_ == null)
				{
					this.RogueTournCurInfo = new RogueMagicCurInfo();
				}
				this.RogueTournCurInfo.MergeFrom(other.RogueTournCurInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600ACE4 RID: 44260 RVA: 0x001D1424 File Offset: 0x001CF624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ACE5 RID: 44261 RVA: 0x001D1430 File Offset: 0x001CF630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 18U)
				{
					if (num != 74U)
					{
						if (num != 88U)
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
						if (this.rogueTournCurInfo_ == null)
						{
							this.RogueTournCurInfo = new RogueMagicCurInfo();
						}
						input.ReadMessage(this.RogueTournCurInfo);
					}
				}
				else
				{
					if (this.rogueTournCurSceneInfo_ == null)
					{
						this.RogueTournCurSceneInfo = new RogueMagicCurSceneInfo();
					}
					input.ReadMessage(this.RogueTournCurSceneInfo);
				}
			}
		}

		// Token: 0x0400466E RID: 18030
		private static readonly MessageParser<RogueMagicStartScRsp> _parser = new MessageParser<RogueMagicStartScRsp>(() => new RogueMagicStartScRsp());

		// Token: 0x0400466F RID: 18031
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004670 RID: 18032
		public const int RetcodeFieldNumber = 11;

		// Token: 0x04004671 RID: 18033
		private uint retcode_;

		// Token: 0x04004672 RID: 18034
		public const int RogueTournCurSceneInfoFieldNumber = 2;

		// Token: 0x04004673 RID: 18035
		private RogueMagicCurSceneInfo rogueTournCurSceneInfo_;

		// Token: 0x04004674 RID: 18036
		public const int RogueTournCurInfoFieldNumber = 9;

		// Token: 0x04004675 RID: 18037
		private RogueMagicCurInfo rogueTournCurInfo_;
	}
}
