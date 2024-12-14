using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004B3 RID: 1203
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildQueryInfoScRsp : IMessage<EvolveBuildQueryInfoScRsp>, IMessage, IEquatable<EvolveBuildQueryInfoScRsp>, IDeepCloneable<EvolveBuildQueryInfoScRsp>, IBufferMessage
	{
		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x060035C4 RID: 13764 RVA: 0x000940EB File Offset: 0x000922EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildQueryInfoScRsp> Parser
		{
			get
			{
				return EvolveBuildQueryInfoScRsp._parser;
			}
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x060035C5 RID: 13765 RVA: 0x000940F2 File Offset: 0x000922F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildQueryInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x060035C6 RID: 13766 RVA: 0x00094104 File Offset: 0x00092304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildQueryInfoScRsp.Descriptor;
			}
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x0009410B File Offset: 0x0009230B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildQueryInfoScRsp()
		{
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x00094114 File Offset: 0x00092314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildQueryInfoScRsp(EvolveBuildQueryInfoScRsp other) : this()
		{
			this.levelInfo_ = ((other.levelInfo_ != null) ? other.levelInfo_.Clone() : null);
			this.rogueCurrentInfo_ = ((other.rogueCurrentInfo_ != null) ? other.rogueCurrentInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x0009417C File Offset: 0x0009237C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildQueryInfoScRsp Clone()
		{
			return new EvolveBuildQueryInfoScRsp(this);
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x060035CA RID: 13770 RVA: 0x00094184 File Offset: 0x00092384
		// (set) Token: 0x060035CB RID: 13771 RVA: 0x0009418C File Offset: 0x0009238C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildLevelInfo LevelInfo
		{
			get
			{
				return this.levelInfo_;
			}
			set
			{
				this.levelInfo_ = value;
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x060035CC RID: 13772 RVA: 0x00094195 File Offset: 0x00092395
		// (set) Token: 0x060035CD RID: 13773 RVA: 0x0009419D File Offset: 0x0009239D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KBBMNPCNHMO RogueCurrentInfo
		{
			get
			{
				return this.rogueCurrentInfo_;
			}
			set
			{
				this.rogueCurrentInfo_ = value;
			}
		}

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x060035CE RID: 13774 RVA: 0x000941A6 File Offset: 0x000923A6
		// (set) Token: 0x060035CF RID: 13775 RVA: 0x000941AE File Offset: 0x000923AE
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

		// Token: 0x060035D0 RID: 13776 RVA: 0x000941B7 File Offset: 0x000923B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildQueryInfoScRsp);
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x000941C8 File Offset: 0x000923C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildQueryInfoScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.LevelInfo, other.LevelInfo) && object.Equals(this.RogueCurrentInfo, other.RogueCurrentInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x0009422C File Offset: 0x0009242C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.levelInfo_ != null)
			{
				num ^= this.LevelInfo.GetHashCode();
			}
			if (this.rogueCurrentInfo_ != null)
			{
				num ^= this.RogueCurrentInfo.GetHashCode();
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

		// Token: 0x060035D3 RID: 13779 RVA: 0x00094297 File Offset: 0x00092497
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x0009429F File Offset: 0x0009249F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060035D5 RID: 13781 RVA: 0x000942A8 File Offset: 0x000924A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.levelInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.LevelInfo);
			}
			if (this.rogueCurrentInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RogueCurrentInfo);
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

		// Token: 0x060035D6 RID: 13782 RVA: 0x00094320 File Offset: 0x00092520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.levelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LevelInfo);
			}
			if (this.rogueCurrentInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueCurrentInfo);
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

		// Token: 0x060035D7 RID: 13783 RVA: 0x00094390 File Offset: 0x00092590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildQueryInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.levelInfo_ != null)
			{
				if (this.levelInfo_ == null)
				{
					this.LevelInfo = new EvolveBuildLevelInfo();
				}
				this.LevelInfo.MergeFrom(other.LevelInfo);
			}
			if (other.rogueCurrentInfo_ != null)
			{
				if (this.rogueCurrentInfo_ == null)
				{
					this.RogueCurrentInfo = new KBBMNPCNHMO();
				}
				this.RogueCurrentInfo.MergeFrom(other.RogueCurrentInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060035D8 RID: 13784 RVA: 0x00094424 File Offset: 0x00092624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060035D9 RID: 13785 RVA: 0x00094430 File Offset: 0x00092630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 34U)
				{
					if (num != 58U)
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
						if (this.rogueCurrentInfo_ == null)
						{
							this.RogueCurrentInfo = new KBBMNPCNHMO();
						}
						input.ReadMessage(this.RogueCurrentInfo);
					}
				}
				else
				{
					if (this.levelInfo_ == null)
					{
						this.LevelInfo = new EvolveBuildLevelInfo();
					}
					input.ReadMessage(this.LevelInfo);
				}
			}
		}

		// Token: 0x0400156F RID: 5487
		private static readonly MessageParser<EvolveBuildQueryInfoScRsp> _parser = new MessageParser<EvolveBuildQueryInfoScRsp>(() => new EvolveBuildQueryInfoScRsp());

		// Token: 0x04001570 RID: 5488
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001571 RID: 5489
		public const int LevelInfoFieldNumber = 4;

		// Token: 0x04001572 RID: 5490
		private EvolveBuildLevelInfo levelInfo_;

		// Token: 0x04001573 RID: 5491
		public const int RogueCurrentInfoFieldNumber = 7;

		// Token: 0x04001574 RID: 5492
		private KBBMNPCNHMO rogueCurrentInfo_;

		// Token: 0x04001575 RID: 5493
		public const int RetcodeFieldNumber = 13;

		// Token: 0x04001576 RID: 5494
		private uint retcode_;
	}
}
