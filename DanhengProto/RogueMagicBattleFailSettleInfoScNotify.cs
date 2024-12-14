using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EB5 RID: 3765
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueMagicBattleFailSettleInfoScNotify : IMessage<RogueMagicBattleFailSettleInfoScNotify>, IMessage, IEquatable<RogueMagicBattleFailSettleInfoScNotify>, IDeepCloneable<RogueMagicBattleFailSettleInfoScNotify>, IBufferMessage
	{
		// Token: 0x17002F83 RID: 12163
		// (get) Token: 0x0600A834 RID: 43060 RVA: 0x001C4F53 File Offset: 0x001C3153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueMagicBattleFailSettleInfoScNotify> Parser
		{
			get
			{
				return RogueMagicBattleFailSettleInfoScNotify._parser;
			}
		}

		// Token: 0x17002F84 RID: 12164
		// (get) Token: 0x0600A835 RID: 43061 RVA: 0x001C4F5A File Offset: 0x001C315A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueMagicBattleFailSettleInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002F85 RID: 12165
		// (get) Token: 0x0600A836 RID: 43062 RVA: 0x001C4F6C File Offset: 0x001C316C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueMagicBattleFailSettleInfoScNotify.Descriptor;
			}
		}

		// Token: 0x0600A837 RID: 43063 RVA: 0x001C4F73 File Offset: 0x001C3173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicBattleFailSettleInfoScNotify()
		{
		}

		// Token: 0x0600A838 RID: 43064 RVA: 0x001C4F7C File Offset: 0x001C317C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicBattleFailSettleInfoScNotify(RogueMagicBattleFailSettleInfoScNotify other) : this()
		{
			this.tournFinishInfo_ = ((other.tournFinishInfo_ != null) ? other.tournFinishInfo_.Clone() : null);
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A839 RID: 43065 RVA: 0x001C4FD8 File Offset: 0x001C31D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicBattleFailSettleInfoScNotify Clone()
		{
			return new RogueMagicBattleFailSettleInfoScNotify(this);
		}

		// Token: 0x17002F86 RID: 12166
		// (get) Token: 0x0600A83A RID: 43066 RVA: 0x001C4FE0 File Offset: 0x001C31E0
		// (set) Token: 0x0600A83B RID: 43067 RVA: 0x001C4FE8 File Offset: 0x001C31E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicFinishInfo TournFinishInfo
		{
			get
			{
				return this.tournFinishInfo_;
			}
			set
			{
				this.tournFinishInfo_ = value;
			}
		}

		// Token: 0x17002F87 RID: 12167
		// (get) Token: 0x0600A83C RID: 43068 RVA: 0x001C4FF1 File Offset: 0x001C31F1
		// (set) Token: 0x0600A83D RID: 43069 RVA: 0x001C4FF9 File Offset: 0x001C31F9
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

		// Token: 0x0600A83E RID: 43070 RVA: 0x001C5002 File Offset: 0x001C3202
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueMagicBattleFailSettleInfoScNotify);
		}

		// Token: 0x0600A83F RID: 43071 RVA: 0x001C5010 File Offset: 0x001C3210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueMagicBattleFailSettleInfoScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.TournFinishInfo, other.TournFinishInfo) && object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A840 RID: 43072 RVA: 0x001C5064 File Offset: 0x001C3264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.tournFinishInfo_ != null)
			{
				num ^= this.TournFinishInfo.GetHashCode();
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

		// Token: 0x0600A841 RID: 43073 RVA: 0x001C50B6 File Offset: 0x001C32B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A842 RID: 43074 RVA: 0x001C50BE File Offset: 0x001C32BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A843 RID: 43075 RVA: 0x001C50C8 File Offset: 0x001C32C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rogueTournCurSceneInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.RogueTournCurSceneInfo);
			}
			if (this.tournFinishInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.TournFinishInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A844 RID: 43076 RVA: 0x001C5124 File Offset: 0x001C3324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.tournFinishInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TournFinishInfo);
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

		// Token: 0x0600A845 RID: 43077 RVA: 0x001C517C File Offset: 0x001C337C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueMagicBattleFailSettleInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.tournFinishInfo_ != null)
			{
				if (this.tournFinishInfo_ == null)
				{
					this.TournFinishInfo = new RogueMagicFinishInfo();
				}
				this.TournFinishInfo.MergeFrom(other.TournFinishInfo);
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

		// Token: 0x0600A846 RID: 43078 RVA: 0x001C51FC File Offset: 0x001C33FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A847 RID: 43079 RVA: 0x001C5208 File Offset: 0x001C3408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 74U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.tournFinishInfo_ == null)
						{
							this.TournFinishInfo = new RogueMagicFinishInfo();
						}
						input.ReadMessage(this.TournFinishInfo);
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

		// Token: 0x040044BF RID: 17599
		private static readonly MessageParser<RogueMagicBattleFailSettleInfoScNotify> _parser = new MessageParser<RogueMagicBattleFailSettleInfoScNotify>(() => new RogueMagicBattleFailSettleInfoScNotify());

		// Token: 0x040044C0 RID: 17600
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044C1 RID: 17601
		public const int TournFinishInfoFieldNumber = 12;

		// Token: 0x040044C2 RID: 17602
		private RogueMagicFinishInfo tournFinishInfo_;

		// Token: 0x040044C3 RID: 17603
		public const int RogueTournCurSceneInfoFieldNumber = 9;

		// Token: 0x040044C4 RID: 17604
		private RogueMagicCurSceneInfo rogueTournCurSceneInfo_;
	}
}
