using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004C5 RID: 1221
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildStartLevelCsReq : IMessage<EvolveBuildStartLevelCsReq>, IMessage, IEquatable<EvolveBuildStartLevelCsReq>, IDeepCloneable<EvolveBuildStartLevelCsReq>, IBufferMessage
	{
		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06003694 RID: 13972 RVA: 0x00095FD7 File Offset: 0x000941D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildStartLevelCsReq> Parser
		{
			get
			{
				return EvolveBuildStartLevelCsReq._parser;
			}
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06003695 RID: 13973 RVA: 0x00095FDE File Offset: 0x000941DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildStartLevelCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06003696 RID: 13974 RVA: 0x00095FF0 File Offset: 0x000941F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildStartLevelCsReq.Descriptor;
			}
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x00095FF7 File Offset: 0x000941F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildStartLevelCsReq()
		{
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x0009600C File Offset: 0x0009420C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildStartLevelCsReq(EvolveBuildStartLevelCsReq other) : this()
		{
			this.levelId_ = other.levelId_;
			this.avatarList_ = other.avatarList_.Clone();
			this.jJLFIBAAJNJ_ = ((other.jJLFIBAAJNJ_ != null) ? other.jJLFIBAAJNJ_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x00096069 File Offset: 0x00094269
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildStartLevelCsReq Clone()
		{
			return new EvolveBuildStartLevelCsReq(this);
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x0600369A RID: 13978 RVA: 0x00096071 File Offset: 0x00094271
		// (set) Token: 0x0600369B RID: 13979 RVA: 0x00096079 File Offset: 0x00094279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x0600369C RID: 13980 RVA: 0x00096082 File Offset: 0x00094282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EvolveBuildAvatar> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x0600369D RID: 13981 RVA: 0x0009608A File Offset: 0x0009428A
		// (set) Token: 0x0600369E RID: 13982 RVA: 0x00096092 File Offset: 0x00094292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NGIKGHKMAHA JJLFIBAAJNJ
		{
			get
			{
				return this.jJLFIBAAJNJ_;
			}
			set
			{
				this.jJLFIBAAJNJ_ = value;
			}
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x0009609B File Offset: 0x0009429B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildStartLevelCsReq);
		}

		// Token: 0x060036A0 RID: 13984 RVA: 0x000960AC File Offset: 0x000942AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildStartLevelCsReq other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.avatarList_.Equals(other.avatarList_) && object.Equals(this.JJLFIBAAJNJ, other.JJLFIBAAJNJ) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060036A1 RID: 13985 RVA: 0x00096110 File Offset: 0x00094310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0U)
			{
				num ^= this.LevelId.GetHashCode();
			}
			num ^= this.avatarList_.GetHashCode();
			if (this.jJLFIBAAJNJ_ != null)
			{
				num ^= this.JJLFIBAAJNJ.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060036A2 RID: 13986 RVA: 0x00096173 File Offset: 0x00094373
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x0009617B File Offset: 0x0009437B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x00096184 File Offset: 0x00094384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.LevelId);
			}
			if (this.jJLFIBAAJNJ_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.JJLFIBAAJNJ);
			}
			this.avatarList_.WriteTo(ref output, EvolveBuildStartLevelCsReq._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x000961F0 File Offset: 0x000943F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.LevelId);
			}
			num += this.avatarList_.CalculateSize(EvolveBuildStartLevelCsReq._repeated_avatarList_codec);
			if (this.jJLFIBAAJNJ_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.JJLFIBAAJNJ);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x0009625C File Offset: 0x0009445C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildStartLevelCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0U)
			{
				this.LevelId = other.LevelId;
			}
			this.avatarList_.Add(other.avatarList_);
			if (other.jJLFIBAAJNJ_ != null)
			{
				if (this.jJLFIBAAJNJ_ == null)
				{
					this.JJLFIBAAJNJ = new NGIKGHKMAHA();
				}
				this.JJLFIBAAJNJ.MergeFrom(other.JJLFIBAAJNJ);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x000962D5 File Offset: 0x000944D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x000962E0 File Offset: 0x000944E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 98U)
					{
						if (num != 106U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.avatarList_.AddEntriesFrom(ref input, EvolveBuildStartLevelCsReq._repeated_avatarList_codec);
						}
					}
					else
					{
						if (this.jJLFIBAAJNJ_ == null)
						{
							this.JJLFIBAAJNJ = new NGIKGHKMAHA();
						}
						input.ReadMessage(this.JJLFIBAAJNJ);
					}
				}
				else
				{
					this.LevelId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040015B1 RID: 5553
		private static readonly MessageParser<EvolveBuildStartLevelCsReq> _parser = new MessageParser<EvolveBuildStartLevelCsReq>(() => new EvolveBuildStartLevelCsReq());

		// Token: 0x040015B2 RID: 5554
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015B3 RID: 5555
		public const int LevelIdFieldNumber = 4;

		// Token: 0x040015B4 RID: 5556
		private uint levelId_;

		// Token: 0x040015B5 RID: 5557
		public const int AvatarListFieldNumber = 13;

		// Token: 0x040015B6 RID: 5558
		private static readonly FieldCodec<EvolveBuildAvatar> _repeated_avatarList_codec = FieldCodec.ForMessage<EvolveBuildAvatar>(106U, EvolveBuildAvatar.Parser);

		// Token: 0x040015B7 RID: 5559
		private readonly RepeatedField<EvolveBuildAvatar> avatarList_ = new RepeatedField<EvolveBuildAvatar>();

		// Token: 0x040015B8 RID: 5560
		public const int JJLFIBAAJNJFieldNumber = 12;

		// Token: 0x040015B9 RID: 5561
		private NGIKGHKMAHA jJLFIBAAJNJ_;
	}
}
