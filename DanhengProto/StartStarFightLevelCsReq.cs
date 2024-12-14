using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020011C9 RID: 4553
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class StartStarFightLevelCsReq : IMessage<StartStarFightLevelCsReq>, IMessage, IEquatable<StartStarFightLevelCsReq>, IDeepCloneable<StartStarFightLevelCsReq>, IBufferMessage
	{
		// Token: 0x17003966 RID: 14694
		// (get) Token: 0x0600CB76 RID: 52086 RVA: 0x002222EB File Offset: 0x002204EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<StartStarFightLevelCsReq> Parser
		{
			get
			{
				return StartStarFightLevelCsReq._parser;
			}
		}

		// Token: 0x17003967 RID: 14695
		// (get) Token: 0x0600CB77 RID: 52087 RVA: 0x002222F2 File Offset: 0x002204F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return StartStarFightLevelCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003968 RID: 14696
		// (get) Token: 0x0600CB78 RID: 52088 RVA: 0x00222304 File Offset: 0x00220504
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartStarFightLevelCsReq.Descriptor;
			}
		}

		// Token: 0x0600CB79 RID: 52089 RVA: 0x0022230B File Offset: 0x0022050B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartStarFightLevelCsReq()
		{
		}

		// Token: 0x0600CB7A RID: 52090 RVA: 0x00222320 File Offset: 0x00220520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartStarFightLevelCsReq(StartStarFightLevelCsReq other) : this()
		{
			this.groupId_ = other.groupId_;
			this.aHFNGPLDAII_ = other.aHFNGPLDAII_;
			this.avatarList_ = other.avatarList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CB7B RID: 52091 RVA: 0x0022236D File Offset: 0x0022056D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartStarFightLevelCsReq Clone()
		{
			return new StartStarFightLevelCsReq(this);
		}

		// Token: 0x17003969 RID: 14697
		// (get) Token: 0x0600CB7C RID: 52092 RVA: 0x00222375 File Offset: 0x00220575
		// (set) Token: 0x0600CB7D RID: 52093 RVA: 0x0022237D File Offset: 0x0022057D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x1700396A RID: 14698
		// (get) Token: 0x0600CB7E RID: 52094 RVA: 0x00222386 File Offset: 0x00220586
		// (set) Token: 0x0600CB7F RID: 52095 RVA: 0x0022238E File Offset: 0x0022058E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AHFNGPLDAII
		{
			get
			{
				return this.aHFNGPLDAII_;
			}
			set
			{
				this.aHFNGPLDAII_ = value;
			}
		}

		// Token: 0x1700396B RID: 14699
		// (get) Token: 0x0600CB80 RID: 52096 RVA: 0x00222397 File Offset: 0x00220597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<IPCMEMCHCPI> AvatarList
		{
			get
			{
				return this.avatarList_;
			}
		}

		// Token: 0x0600CB81 RID: 52097 RVA: 0x0022239F File Offset: 0x0022059F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartStarFightLevelCsReq);
		}

		// Token: 0x0600CB82 RID: 52098 RVA: 0x002223B0 File Offset: 0x002205B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartStarFightLevelCsReq other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.AHFNGPLDAII == other.AHFNGPLDAII && this.avatarList_.Equals(other.avatarList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB83 RID: 52099 RVA: 0x00222410 File Offset: 0x00220610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.AHFNGPLDAII != 0U)
			{
				num ^= this.AHFNGPLDAII.GetHashCode();
			}
			num ^= this.avatarList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CB84 RID: 52100 RVA: 0x00222476 File Offset: 0x00220676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600CB85 RID: 52101 RVA: 0x0022247E File Offset: 0x0022067E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB86 RID: 52102 RVA: 0x00222488 File Offset: 0x00220688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.avatarList_.WriteTo(ref output, StartStarFightLevelCsReq._repeated_avatarList_codec);
			if (this.AHFNGPLDAII != 0U)
			{
				output.WriteRawTag(80);
				output.WriteUInt32(this.AHFNGPLDAII);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CB87 RID: 52103 RVA: 0x002224F4 File Offset: 0x002206F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.AHFNGPLDAII != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AHFNGPLDAII);
			}
			num += this.avatarList_.CalculateSize(StartStarFightLevelCsReq._repeated_avatarList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CB88 RID: 52104 RVA: 0x00222560 File Offset: 0x00220760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartStarFightLevelCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.AHFNGPLDAII != 0U)
			{
				this.AHFNGPLDAII = other.AHFNGPLDAII;
			}
			this.avatarList_.Add(other.avatarList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CB89 RID: 52105 RVA: 0x002225C1 File Offset: 0x002207C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB8A RID: 52106 RVA: 0x002225CC File Offset: 0x002207CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					if (num != 80U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GroupId = input.ReadUInt32();
						}
					}
					else
					{
						this.AHFNGPLDAII = input.ReadUInt32();
					}
				}
				else
				{
					this.avatarList_.AddEntriesFrom(ref input, StartStarFightLevelCsReq._repeated_avatarList_codec);
				}
			}
		}

		// Token: 0x04005216 RID: 21014
		private static readonly MessageParser<StartStarFightLevelCsReq> _parser = new MessageParser<StartStarFightLevelCsReq>(() => new StartStarFightLevelCsReq());

		// Token: 0x04005217 RID: 21015
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005218 RID: 21016
		public const int GroupIdFieldNumber = 14;

		// Token: 0x04005219 RID: 21017
		private uint groupId_;

		// Token: 0x0400521A RID: 21018
		public const int AHFNGPLDAIIFieldNumber = 10;

		// Token: 0x0400521B RID: 21019
		private uint aHFNGPLDAII_;

		// Token: 0x0400521C RID: 21020
		public const int AvatarListFieldNumber = 7;

		// Token: 0x0400521D RID: 21021
		private static readonly FieldCodec<IPCMEMCHCPI> _repeated_avatarList_codec = FieldCodec.ForMessage<IPCMEMCHCPI>(58U, IPCMEMCHCPI.Parser);

		// Token: 0x0400521E RID: 21022
		private readonly RepeatedField<IPCMEMCHCPI> avatarList_ = new RepeatedField<IPCMEMCHCPI>();
	}
}
