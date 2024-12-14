using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A01 RID: 2561
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LeaveRogueScRsp : IMessage<LeaveRogueScRsp>, IMessage, IEquatable<LeaveRogueScRsp>, IDeepCloneable<LeaveRogueScRsp>, IBufferMessage
	{
		// Token: 0x17001FF1 RID: 8177
		// (get) Token: 0x060071A4 RID: 29092 RVA: 0x0012E59B File Offset: 0x0012C79B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LeaveRogueScRsp> Parser
		{
			get
			{
				return LeaveRogueScRsp._parser;
			}
		}

		// Token: 0x17001FF2 RID: 8178
		// (get) Token: 0x060071A5 RID: 29093 RVA: 0x0012E5A2 File Offset: 0x0012C7A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LeaveRogueScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FF3 RID: 8179
		// (get) Token: 0x060071A6 RID: 29094 RVA: 0x0012E5B4 File Offset: 0x0012C7B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LeaveRogueScRsp.Descriptor;
			}
		}

		// Token: 0x060071A7 RID: 29095 RVA: 0x0012E5BB File Offset: 0x0012C7BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveRogueScRsp()
		{
		}

		// Token: 0x060071A8 RID: 29096 RVA: 0x0012E5C4 File Offset: 0x0012C7C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveRogueScRsp(LeaveRogueScRsp other) : this()
		{
			this.rotateInfo_ = ((other.rotateInfo_ != null) ? other.rotateInfo_.Clone() : null);
			this.rogueGameInfo_ = ((other.rogueGameInfo_ != null) ? other.rogueGameInfo_.Clone() : null);
			this.lineup_ = ((other.lineup_ != null) ? other.lineup_.Clone() : null);
			this.retcode_ = other.retcode_;
			this.scene_ = ((other.scene_ != null) ? other.scene_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060071A9 RID: 29097 RVA: 0x0012E664 File Offset: 0x0012C864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LeaveRogueScRsp Clone()
		{
			return new LeaveRogueScRsp(this);
		}

		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x060071AA RID: 29098 RVA: 0x0012E66C File Offset: 0x0012C86C
		// (set) Token: 0x060071AB RID: 29099 RVA: 0x0012E674 File Offset: 0x0012C874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMapRotateInfo RotateInfo
		{
			get
			{
				return this.rotateInfo_;
			}
			set
			{
				this.rotateInfo_ = value;
			}
		}

		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x060071AC RID: 29100 RVA: 0x0012E67D File Offset: 0x0012C87D
		// (set) Token: 0x060071AD RID: 29101 RVA: 0x0012E685 File Offset: 0x0012C885
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInfo RogueGameInfo
		{
			get
			{
				return this.rogueGameInfo_;
			}
			set
			{
				this.rogueGameInfo_ = value;
			}
		}

		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x060071AE RID: 29102 RVA: 0x0012E68E File Offset: 0x0012C88E
		// (set) Token: 0x060071AF RID: 29103 RVA: 0x0012E696 File Offset: 0x0012C896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineupInfo Lineup
		{
			get
			{
				return this.lineup_;
			}
			set
			{
				this.lineup_ = value;
			}
		}

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x060071B0 RID: 29104 RVA: 0x0012E69F File Offset: 0x0012C89F
		// (set) Token: 0x060071B1 RID: 29105 RVA: 0x0012E6A7 File Offset: 0x0012C8A7
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

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x060071B2 RID: 29106 RVA: 0x0012E6B0 File Offset: 0x0012C8B0
		// (set) Token: 0x060071B3 RID: 29107 RVA: 0x0012E6B8 File Offset: 0x0012C8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneInfo Scene
		{
			get
			{
				return this.scene_;
			}
			set
			{
				this.scene_ = value;
			}
		}

		// Token: 0x060071B4 RID: 29108 RVA: 0x0012E6C1 File Offset: 0x0012C8C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LeaveRogueScRsp);
		}

		// Token: 0x060071B5 RID: 29109 RVA: 0x0012E6D0 File Offset: 0x0012C8D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LeaveRogueScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.RotateInfo, other.RotateInfo) && object.Equals(this.RogueGameInfo, other.RogueGameInfo) && object.Equals(this.Lineup, other.Lineup) && this.Retcode == other.Retcode && object.Equals(this.Scene, other.Scene) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060071B6 RID: 29110 RVA: 0x0012E760 File Offset: 0x0012C960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rotateInfo_ != null)
			{
				num ^= this.RotateInfo.GetHashCode();
			}
			if (this.rogueGameInfo_ != null)
			{
				num ^= this.RogueGameInfo.GetHashCode();
			}
			if (this.lineup_ != null)
			{
				num ^= this.Lineup.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.scene_ != null)
			{
				num ^= this.Scene.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060071B7 RID: 29111 RVA: 0x0012E7F7 File Offset: 0x0012C9F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060071B8 RID: 29112 RVA: 0x0012E7FF File Offset: 0x0012C9FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060071B9 RID: 29113 RVA: 0x0012E808 File Offset: 0x0012CA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rotateInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.RotateInfo);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.Retcode);
			}
			if (this.lineup_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Lineup);
			}
			if (this.rogueGameInfo_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.RogueGameInfo);
			}
			if (this.scene_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Scene);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060071BA RID: 29114 RVA: 0x0012E8B8 File Offset: 0x0012CAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rotateInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RotateInfo);
			}
			if (this.rogueGameInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueGameInfo);
			}
			if (this.lineup_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Lineup);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.scene_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scene);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060071BB RID: 29115 RVA: 0x0012E958 File Offset: 0x0012CB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LeaveRogueScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rotateInfo_ != null)
			{
				if (this.rotateInfo_ == null)
				{
					this.RotateInfo = new RogueMapRotateInfo();
				}
				this.RotateInfo.MergeFrom(other.RotateInfo);
			}
			if (other.rogueGameInfo_ != null)
			{
				if (this.rogueGameInfo_ == null)
				{
					this.RogueGameInfo = new RogueInfo();
				}
				this.RogueGameInfo.MergeFrom(other.RogueGameInfo);
			}
			if (other.lineup_ != null)
			{
				if (this.lineup_ == null)
				{
					this.Lineup = new LineupInfo();
				}
				this.Lineup.MergeFrom(other.Lineup);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.scene_ != null)
			{
				if (this.scene_ == null)
				{
					this.Scene = new SceneInfo();
				}
				this.Scene.MergeFrom(other.Scene);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060071BC RID: 29116 RVA: 0x0012EA44 File Offset: 0x0012CC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060071BD RID: 29117 RVA: 0x0012EA50 File Offset: 0x0012CC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 80U)
				{
					if (num == 58U)
					{
						if (this.rotateInfo_ == null)
						{
							this.RotateInfo = new RogueMapRotateInfo();
						}
						input.ReadMessage(this.RotateInfo);
						continue;
					}
					if (num == 80U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						if (this.lineup_ == null)
						{
							this.Lineup = new LineupInfo();
						}
						input.ReadMessage(this.Lineup);
						continue;
					}
					if (num == 98U)
					{
						if (this.rogueGameInfo_ == null)
						{
							this.RogueGameInfo = new RogueInfo();
						}
						input.ReadMessage(this.RogueGameInfo);
						continue;
					}
					if (num == 114U)
					{
						if (this.scene_ == null)
						{
							this.Scene = new SceneInfo();
						}
						input.ReadMessage(this.Scene);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002BAF RID: 11183
		private static readonly MessageParser<LeaveRogueScRsp> _parser = new MessageParser<LeaveRogueScRsp>(() => new LeaveRogueScRsp());

		// Token: 0x04002BB0 RID: 11184
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002BB1 RID: 11185
		public const int RotateInfoFieldNumber = 7;

		// Token: 0x04002BB2 RID: 11186
		private RogueMapRotateInfo rotateInfo_;

		// Token: 0x04002BB3 RID: 11187
		public const int RogueGameInfoFieldNumber = 12;

		// Token: 0x04002BB4 RID: 11188
		private RogueInfo rogueGameInfo_;

		// Token: 0x04002BB5 RID: 11189
		public const int LineupFieldNumber = 11;

		// Token: 0x04002BB6 RID: 11190
		private LineupInfo lineup_;

		// Token: 0x04002BB7 RID: 11191
		public const int RetcodeFieldNumber = 10;

		// Token: 0x04002BB8 RID: 11192
		private uint retcode_;

		// Token: 0x04002BB9 RID: 11193
		public const int SceneFieldNumber = 14;

		// Token: 0x04002BBA RID: 11194
		private SceneInfo scene_;
	}
}
