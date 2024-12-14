using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200023F RID: 575
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ChessRogueLineupAvatarInfo : IMessage<ChessRogueLineupAvatarInfo>, IMessage, IEquatable<ChessRogueLineupAvatarInfo>, IDeepCloneable<ChessRogueLineupAvatarInfo>, IBufferMessage
	{
		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x0004B671 File Offset: 0x00049871
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ChessRogueLineupAvatarInfo> Parser
		{
			get
			{
				return ChessRogueLineupAvatarInfo._parser;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060019DF RID: 6623 RVA: 0x0004B678 File Offset: 0x00049878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChessRogueLineupAvatarInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x0004B68A File Offset: 0x0004988A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChessRogueLineupAvatarInfo.Descriptor;
			}
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0004B691 File Offset: 0x00049891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLineupAvatarInfo()
		{
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x0004B699 File Offset: 0x00049899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLineupAvatarInfo(ChessRogueLineupAvatarInfo other) : this()
		{
			this.pBHENLJDKDJ_ = other.pBHENLJDKDJ_;
			this.avatarId_ = other.avatarId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x0004B6CA File Offset: 0x000498CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChessRogueLineupAvatarInfo Clone()
		{
			return new ChessRogueLineupAvatarInfo(this);
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x0004B6D2 File Offset: 0x000498D2
		// (set) Token: 0x060019E5 RID: 6629 RVA: 0x0004B6DA File Offset: 0x000498DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint PBHENLJDKDJ
		{
			get
			{
				return this.pBHENLJDKDJ_;
			}
			set
			{
				this.pBHENLJDKDJ_ = value;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x0004B6E3 File Offset: 0x000498E3
		// (set) Token: 0x060019E7 RID: 6631 RVA: 0x0004B6EB File Offset: 0x000498EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AvatarId
		{
			get
			{
				return this.avatarId_;
			}
			set
			{
				this.avatarId_ = value;
			}
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x0004B6F4 File Offset: 0x000498F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChessRogueLineupAvatarInfo);
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x0004B702 File Offset: 0x00049902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChessRogueLineupAvatarInfo other)
		{
			return other != null && (other == this || (this.PBHENLJDKDJ == other.PBHENLJDKDJ && this.AvatarId == other.AvatarId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x0004B740 File Offset: 0x00049940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PBHENLJDKDJ != 0U)
			{
				num ^= this.PBHENLJDKDJ.GetHashCode();
			}
			if (this.AvatarId != 0U)
			{
				num ^= this.AvatarId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x0004B798 File Offset: 0x00049998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x0004B7A0 File Offset: 0x000499A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x0004B7AC File Offset: 0x000499AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AvatarId != 0U)
			{
				output.WriteRawTag(48);
				output.WriteUInt32(this.AvatarId);
			}
			if (this.PBHENLJDKDJ != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.PBHENLJDKDJ);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x0004B808 File Offset: 0x00049A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PBHENLJDKDJ != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.PBHENLJDKDJ);
			}
			if (this.AvatarId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AvatarId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x0004B860 File Offset: 0x00049A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChessRogueLineupAvatarInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PBHENLJDKDJ != 0U)
			{
				this.PBHENLJDKDJ = other.PBHENLJDKDJ;
			}
			if (other.AvatarId != 0U)
			{
				this.AvatarId = other.AvatarId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x0004B8B0 File Offset: 0x00049AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x0004B8BC File Offset: 0x00049ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 48U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.PBHENLJDKDJ = input.ReadUInt32();
					}
				}
				else
				{
					this.AvatarId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000B0C RID: 2828
		private static readonly MessageParser<ChessRogueLineupAvatarInfo> _parser = new MessageParser<ChessRogueLineupAvatarInfo>(() => new ChessRogueLineupAvatarInfo());

		// Token: 0x04000B0D RID: 2829
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000B0E RID: 2830
		public const int PBHENLJDKDJFieldNumber = 12;

		// Token: 0x04000B0F RID: 2831
		private uint pBHENLJDKDJ_;

		// Token: 0x04000B10 RID: 2832
		public const int AvatarIdFieldNumber = 6;

		// Token: 0x04000B11 RID: 2833
		private uint avatarId_;
	}
}
