using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F83 RID: 3971
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournBattleFailSettleInfoScNotify : IMessage<RogueTournBattleFailSettleInfoScNotify>, IMessage, IEquatable<RogueTournBattleFailSettleInfoScNotify>, IDeepCloneable<RogueTournBattleFailSettleInfoScNotify>, IBufferMessage
	{
		// Token: 0x170031E1 RID: 12769
		// (get) Token: 0x0600B0D3 RID: 45267 RVA: 0x001DB027 File Offset: 0x001D9227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournBattleFailSettleInfoScNotify> Parser
		{
			get
			{
				return RogueTournBattleFailSettleInfoScNotify._parser;
			}
		}

		// Token: 0x170031E2 RID: 12770
		// (get) Token: 0x0600B0D4 RID: 45268 RVA: 0x001DB02E File Offset: 0x001D922E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournBattleFailSettleInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170031E3 RID: 12771
		// (get) Token: 0x0600B0D5 RID: 45269 RVA: 0x001DB040 File Offset: 0x001D9240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournBattleFailSettleInfoScNotify.Descriptor;
			}
		}

		// Token: 0x0600B0D6 RID: 45270 RVA: 0x001DB047 File Offset: 0x001D9247
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournBattleFailSettleInfoScNotify()
		{
		}

		// Token: 0x0600B0D7 RID: 45271 RVA: 0x001DB050 File Offset: 0x001D9250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournBattleFailSettleInfoScNotify(RogueTournBattleFailSettleInfoScNotify other) : this()
		{
			this.rogueTournCurSceneInfo_ = ((other.rogueTournCurSceneInfo_ != null) ? other.rogueTournCurSceneInfo_.Clone() : null);
			this.tournFinishInfo_ = ((other.tournFinishInfo_ != null) ? other.tournFinishInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B0D8 RID: 45272 RVA: 0x001DB0AC File Offset: 0x001D92AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournBattleFailSettleInfoScNotify Clone()
		{
			return new RogueTournBattleFailSettleInfoScNotify(this);
		}

		// Token: 0x170031E4 RID: 12772
		// (get) Token: 0x0600B0D9 RID: 45273 RVA: 0x001DB0B4 File Offset: 0x001D92B4
		// (set) Token: 0x0600B0DA RID: 45274 RVA: 0x001DB0BC File Offset: 0x001D92BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournCurSceneInfo RogueTournCurSceneInfo
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

		// Token: 0x170031E5 RID: 12773
		// (get) Token: 0x0600B0DB RID: 45275 RVA: 0x001DB0C5 File Offset: 0x001D92C5
		// (set) Token: 0x0600B0DC RID: 45276 RVA: 0x001DB0CD File Offset: 0x001D92CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournFinishInfo TournFinishInfo
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

		// Token: 0x0600B0DD RID: 45277 RVA: 0x001DB0D6 File Offset: 0x001D92D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournBattleFailSettleInfoScNotify);
		}

		// Token: 0x0600B0DE RID: 45278 RVA: 0x001DB0E4 File Offset: 0x001D92E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournBattleFailSettleInfoScNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RogueTournCurSceneInfo, other.RogueTournCurSceneInfo) && object.Equals(this.TournFinishInfo, other.TournFinishInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B0DF RID: 45279 RVA: 0x001DB138 File Offset: 0x001D9338
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num ^= this.RogueTournCurSceneInfo.GetHashCode();
			}
			if (this.tournFinishInfo_ != null)
			{
				num ^= this.TournFinishInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B0E0 RID: 45280 RVA: 0x001DB18A File Offset: 0x001D938A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B0E1 RID: 45281 RVA: 0x001DB192 File Offset: 0x001D9392
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B0E2 RID: 45282 RVA: 0x001DB19C File Offset: 0x001D939C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.tournFinishInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.TournFinishInfo);
			}
			if (this.rogueTournCurSceneInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.RogueTournCurSceneInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B0E3 RID: 45283 RVA: 0x001DB1F8 File Offset: 0x001D93F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rogueTournCurSceneInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueTournCurSceneInfo);
			}
			if (this.tournFinishInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TournFinishInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B0E4 RID: 45284 RVA: 0x001DB250 File Offset: 0x001D9450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournBattleFailSettleInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rogueTournCurSceneInfo_ != null)
			{
				if (this.rogueTournCurSceneInfo_ == null)
				{
					this.RogueTournCurSceneInfo = new RogueTournCurSceneInfo();
				}
				this.RogueTournCurSceneInfo.MergeFrom(other.RogueTournCurSceneInfo);
			}
			if (other.tournFinishInfo_ != null)
			{
				if (this.tournFinishInfo_ == null)
				{
					this.TournFinishInfo = new RogueTournFinishInfo();
				}
				this.TournFinishInfo.MergeFrom(other.TournFinishInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B0E5 RID: 45285 RVA: 0x001DB2D0 File Offset: 0x001D94D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B0E6 RID: 45286 RVA: 0x001DB2DC File Offset: 0x001D94DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 42U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueTournCurSceneInfo_ == null)
						{
							this.RogueTournCurSceneInfo = new RogueTournCurSceneInfo();
						}
						input.ReadMessage(this.RogueTournCurSceneInfo);
					}
				}
				else
				{
					if (this.tournFinishInfo_ == null)
					{
						this.TournFinishInfo = new RogueTournFinishInfo();
					}
					input.ReadMessage(this.TournFinishInfo);
				}
			}
		}

		// Token: 0x040047F4 RID: 18420
		private static readonly MessageParser<RogueTournBattleFailSettleInfoScNotify> _parser = new MessageParser<RogueTournBattleFailSettleInfoScNotify>(() => new RogueTournBattleFailSettleInfoScNotify());

		// Token: 0x040047F5 RID: 18421
		private UnknownFieldSet _unknownFields;

		// Token: 0x040047F6 RID: 18422
		public const int RogueTournCurSceneInfoFieldNumber = 6;

		// Token: 0x040047F7 RID: 18423
		private RogueTournCurSceneInfo rogueTournCurSceneInfo_;

		// Token: 0x040047F8 RID: 18424
		public const int TournFinishInfoFieldNumber = 5;

		// Token: 0x040047F9 RID: 18425
		private RogueTournFinishInfo tournFinishInfo_;
	}
}
