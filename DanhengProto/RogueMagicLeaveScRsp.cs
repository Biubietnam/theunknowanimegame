using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EED RID: 3821
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicLeaveScRsp : IMessage<RogueMagicLeaveScRsp>, IMessage, IEquatable<RogueMagicLeaveScRsp>, IDeepCloneable<RogueMagicLeaveScRsp>, IBufferMessage
	{
		// Token: 0x17003037 RID: 12343
		// (get) Token: 0x0600AAB9 RID: 43705 RVA: 0x001CBE83 File Offset: 0x001CA083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicLeaveScRsp> Parser
		{
			get
			{
				return RogueMagicLeaveScRsp._parser;
			}
		}

		// Token: 0x17003038 RID: 12344
		// (get) Token: 0x0600AABA RID: 43706 RVA: 0x001CBE8A File Offset: 0x001CA08A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicLeaveScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003039 RID: 12345
		// (get) Token: 0x0600AABB RID: 43707 RVA: 0x001CBE9C File Offset: 0x001CA09C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicLeaveScRsp.Descriptor;
			}
		}

		// Token: 0x0600AABC RID: 43708 RVA: 0x001CBEA3 File Offset: 0x001CA0A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicLeaveScRsp()
		{
		}

		// Token: 0x0600AABD RID: 43709 RVA: 0x001CBEAC File Offset: 0x001CA0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicLeaveScRsp(RogueMagicLeaveScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AABE RID: 43710 RVA: 0x001CBEF8 File Offset: 0x001CA0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicLeaveScRsp Clone()
		{
			return new RogueMagicLeaveScRsp(this);
		}

		// Token: 0x1700303A RID: 12346
		// (get) Token: 0x0600AABF RID: 43711 RVA: 0x001CBF00 File Offset: 0x001CA100
		// (set) Token: 0x0600AAC0 RID: 43712 RVA: 0x001CBF08 File Offset: 0x001CA108
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

		// Token: 0x1700303B RID: 12347
		// (get) Token: 0x0600AAC1 RID: 43713 RVA: 0x001CBF11 File Offset: 0x001CA111
		// (set) Token: 0x0600AAC2 RID: 43714 RVA: 0x001CBF19 File Offset: 0x001CA119
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

		// Token: 0x0600AAC3 RID: 43715 RVA: 0x001CBF22 File Offset: 0x001CA122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicLeaveScRsp);
		}

		// Token: 0x0600AAC4 RID: 43716 RVA: 0x001CBF30 File Offset: 0x001CA130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicLeaveScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AAC5 RID: 43717 RVA: 0x001CBF80 File Offset: 0x001CA180
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AAC6 RID: 43718 RVA: 0x001CBFD5 File Offset: 0x001CA1D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AAC7 RID: 43719 RVA: 0x001CBFDD File Offset: 0x001CA1DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AAC8 RID: 43720 RVA: 0x001CBFE8 File Offset: 0x001CA1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.RogueTournCurSceneInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AAC9 RID: 43721 RVA: 0x001CC044 File Offset: 0x001CA244
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AACA RID: 43722 RVA: 0x001CC09C File Offset: 0x001CA29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicLeaveScRsp other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AACB RID: 43723 RVA: 0x001CC104 File Offset: 0x001CA304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AACC RID: 43724 RVA: 0x001CC110 File Offset: 0x001CA310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040045AF RID: 17839
		private static readonly MessageParser<RogueMagicLeaveScRsp> _parser = new MessageParser<RogueMagicLeaveScRsp>(() => new RogueMagicLeaveScRsp());

		// Token: 0x040045B0 RID: 17840
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045B1 RID: 17841
		public const int RetcodeFieldNumber = 2;

		// Token: 0x040045B2 RID: 17842
		private uint retcode_;

		// Token: 0x040045B3 RID: 17843
		public const int RogueTournCurSceneInfoFieldNumber = 14;

		// Token: 0x040045B4 RID: 17844
		private RogueMagicCurSceneInfo rogueTournCurSceneInfo_;
	}
}
