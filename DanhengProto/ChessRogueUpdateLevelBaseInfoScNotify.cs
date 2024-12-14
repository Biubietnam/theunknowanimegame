using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002B3 RID: 691
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueUpdateLevelBaseInfoScNotify : IMessage<ChessRogueUpdateLevelBaseInfoScNotify>, IMessage, IEquatable<ChessRogueUpdateLevelBaseInfoScNotify>, IDeepCloneable<ChessRogueUpdateLevelBaseInfoScNotify>, IBufferMessage
	{
		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06001EDD RID: 7901 RVA: 0x0005841F File Offset: 0x0005661F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueUpdateLevelBaseInfoScNotify> Parser
		{
			get
			{
				return ChessRogueUpdateLevelBaseInfoScNotify._parser;
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06001EDE RID: 7902 RVA: 0x00058426 File Offset: 0x00056626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueUpdateLevelBaseInfoScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x00058438 File Offset: 0x00056638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueUpdateLevelBaseInfoScNotify.Descriptor;
			}
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x0005843F File Offset: 0x0005663F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateLevelBaseInfoScNotify()
		{
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x00058447 File Offset: 0x00056647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateLevelBaseInfoScNotify(ChessRogueUpdateLevelBaseInfoScNotify other) : this()
		{
			this.levelStatus_ = other.levelStatus_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x00058478 File Offset: 0x00056678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateLevelBaseInfoScNotify Clone()
		{
			return new ChessRogueUpdateLevelBaseInfoScNotify(this);
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x00058480 File Offset: 0x00056680
		// (set) Token: 0x06001EE4 RID: 7908 RVA: 0x00058488 File Offset: 0x00056688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLevelStatus LevelStatus
		{
			get
			{
				return this.levelStatus_;
			}
			set
			{
				this.levelStatus_ = value;
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x00058491 File Offset: 0x00056691
		// (set) Token: 0x06001EE6 RID: 7910 RVA: 0x00058499 File Offset: 0x00056699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueUpdateLevelStatus Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x000584A2 File Offset: 0x000566A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueUpdateLevelBaseInfoScNotify);
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x000584B0 File Offset: 0x000566B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueUpdateLevelBaseInfoScNotify other)
		{
			return other != null && (other == this || (this.LevelStatus == other.LevelStatus && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x000584F0 File Offset: 0x000566F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelStatus != ChessRogueLevelStatus.ChessRogueLevelIdle)
			{
				num ^= this.LevelStatus.GetHashCode();
			}
			if (this.Reason != ChessRogueUpdateLevelStatus.ByNone)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00058554 File Offset: 0x00056754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x0005855C File Offset: 0x0005675C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x00058568 File Offset: 0x00056768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Reason != ChessRogueUpdateLevelStatus.ByNone)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.Reason);
			}
			if (this.LevelStatus != ChessRogueLevelStatus.ChessRogueLevelIdle)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.LevelStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x000585C4 File Offset: 0x000567C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelStatus != ChessRogueLevelStatus.ChessRogueLevelIdle)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.LevelStatus);
			}
			if (this.Reason != ChessRogueUpdateLevelStatus.ByNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x0005861C File Offset: 0x0005681C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueUpdateLevelBaseInfoScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelStatus != ChessRogueLevelStatus.ChessRogueLevelIdle)
			{
				this.LevelStatus = other.LevelStatus;
			}
			if (other.Reason != ChessRogueUpdateLevelStatus.ByNone)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x0005866C File Offset: 0x0005686C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001EF0 RID: 7920 RVA: 0x00058678 File Offset: 0x00056878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LevelStatus = (ChessRogueLevelStatus)input.ReadEnum();
					}
				}
				else
				{
					this.Reason = (ChessRogueUpdateLevelStatus)input.ReadEnum();
				}
			}
		}

		// Token: 0x04000CD4 RID: 3284
		private static readonly MessageParser<ChessRogueUpdateLevelBaseInfoScNotify> _parser = new MessageParser<ChessRogueUpdateLevelBaseInfoScNotify>(() => new ChessRogueUpdateLevelBaseInfoScNotify());

		// Token: 0x04000CD5 RID: 3285
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000CD6 RID: 3286
		public const int LevelStatusFieldNumber = 15;

		// Token: 0x04000CD7 RID: 3287
		private ChessRogueLevelStatus levelStatus_;

		// Token: 0x04000CD8 RID: 3288
		public const int ReasonFieldNumber = 12;

		// Token: 0x04000CD9 RID: 3289
		private ChessRogueUpdateLevelStatus reason_;
	}
}
