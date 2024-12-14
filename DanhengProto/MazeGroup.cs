using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000AAF RID: 2735
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class MazeGroup : IMessage<MazeGroup>, IMessage, IEquatable<MazeGroup>, IDeepCloneable<MazeGroup>, IBufferMessage
	{
		// Token: 0x1700220A RID: 8714
		// (get) Token: 0x0600793D RID: 31037 RVA: 0x001414A9 File Offset: 0x0013F6A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MazeGroup> Parser
		{
			get
			{
				return MazeGroup._parser;
			}
		}

		// Token: 0x1700220B RID: 8715
		// (get) Token: 0x0600793E RID: 31038 RVA: 0x001414B0 File Offset: 0x0013F6B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MazeGroupReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700220C RID: 8716
		// (get) Token: 0x0600793F RID: 31039 RVA: 0x001414C2 File Offset: 0x0013F6C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MazeGroup.Descriptor;
			}
		}

		// Token: 0x06007940 RID: 31040 RVA: 0x001414C9 File Offset: 0x0013F6C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MazeGroup()
		{
		}

		// Token: 0x06007941 RID: 31041 RVA: 0x001414DC File Offset: 0x0013F6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MazeGroup(MazeGroup other) : this()
		{
			this.groupId_ = other.groupId_;
			this.dPIKDBPKAOK_ = other.dPIKDBPKAOK_;
			this.lFFHDKHBHNN_ = other.lFFHDKHBHNN_.Clone();
			this.modifyTime_ = other.modifyTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007942 RID: 31042 RVA: 0x00141535 File Offset: 0x0013F735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MazeGroup Clone()
		{
			return new MazeGroup(this);
		}

		// Token: 0x1700220D RID: 8717
		// (get) Token: 0x06007943 RID: 31043 RVA: 0x0014153D File Offset: 0x0013F73D
		// (set) Token: 0x06007944 RID: 31044 RVA: 0x00141545 File Offset: 0x0013F745
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

		// Token: 0x1700220E RID: 8718
		// (get) Token: 0x06007945 RID: 31045 RVA: 0x0014154E File Offset: 0x0013F74E
		// (set) Token: 0x06007946 RID: 31046 RVA: 0x00141556 File Offset: 0x0013F756
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool DPIKDBPKAOK
		{
			get
			{
				return this.dPIKDBPKAOK_;
			}
			set
			{
				this.dPIKDBPKAOK_ = value;
			}
		}

		// Token: 0x1700220F RID: 8719
		// (get) Token: 0x06007947 RID: 31047 RVA: 0x0014155F File Offset: 0x0013F75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> LFFHDKHBHNN
		{
			get
			{
				return this.lFFHDKHBHNN_;
			}
		}

		// Token: 0x17002210 RID: 8720
		// (get) Token: 0x06007948 RID: 31048 RVA: 0x00141567 File Offset: 0x0013F767
		// (set) Token: 0x06007949 RID: 31049 RVA: 0x0014156F File Offset: 0x0013F76F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ModifyTime
		{
			get
			{
				return this.modifyTime_;
			}
			set
			{
				this.modifyTime_ = value;
			}
		}

		// Token: 0x0600794A RID: 31050 RVA: 0x00141578 File Offset: 0x0013F778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MazeGroup);
		}

		// Token: 0x0600794B RID: 31051 RVA: 0x00141588 File Offset: 0x0013F788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MazeGroup other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.DPIKDBPKAOK == other.DPIKDBPKAOK && this.lFFHDKHBHNN_.Equals(other.lFFHDKHBHNN_) && this.ModifyTime == other.ModifyTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600794C RID: 31052 RVA: 0x001415F8 File Offset: 0x0013F7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0U)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.DPIKDBPKAOK)
			{
				num ^= this.DPIKDBPKAOK.GetHashCode();
			}
			num ^= this.lFFHDKHBHNN_.GetHashCode();
			if (this.ModifyTime != 0L)
			{
				num ^= this.ModifyTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600794D RID: 31053 RVA: 0x00141677 File Offset: 0x0013F877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600794E RID: 31054 RVA: 0x0014167F File Offset: 0x0013F87F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600794F RID: 31055 RVA: 0x00141688 File Offset: 0x0013F888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DPIKDBPKAOK)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.DPIKDBPKAOK);
			}
			if (this.GroupId != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.GroupId);
			}
			if (this.ModifyTime != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.ModifyTime);
			}
			this.lFFHDKHBHNN_.WriteTo(ref output, MazeGroup._repeated_lFFHDKHBHNN_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007950 RID: 31056 RVA: 0x00141710 File Offset: 0x0013F910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GroupId);
			}
			if (this.DPIKDBPKAOK)
			{
				num += 2;
			}
			num += this.lFFHDKHBHNN_.CalculateSize(MazeGroup._repeated_lFFHDKHBHNN_codec);
			if (this.ModifyTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ModifyTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007951 RID: 31057 RVA: 0x00141788 File Offset: 0x0013F988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MazeGroup other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0U)
			{
				this.GroupId = other.GroupId;
			}
			if (other.DPIKDBPKAOK)
			{
				this.DPIKDBPKAOK = other.DPIKDBPKAOK;
			}
			this.lFFHDKHBHNN_.Add(other.lFFHDKHBHNN_);
			if (other.ModifyTime != 0L)
			{
				this.ModifyTime = other.ModifyTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007952 RID: 31058 RVA: 0x001417FD File Offset: 0x0013F9FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007953 RID: 31059 RVA: 0x00141808 File Offset: 0x0013FA08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 40U)
				{
					if (num == 16U)
					{
						this.DPIKDBPKAOK = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.GroupId = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.ModifyTime = input.ReadInt64();
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.lFFHDKHBHNN_.AddEntriesFrom(ref input, MazeGroup._repeated_lFFHDKHBHNN_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002E88 RID: 11912
		private static readonly MessageParser<MazeGroup> _parser = new MessageParser<MazeGroup>(() => new MazeGroup());

		// Token: 0x04002E89 RID: 11913
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E8A RID: 11914
		public const int GroupIdFieldNumber = 5;

		// Token: 0x04002E8B RID: 11915
		private uint groupId_;

		// Token: 0x04002E8C RID: 11916
		public const int DPIKDBPKAOKFieldNumber = 2;

		// Token: 0x04002E8D RID: 11917
		private bool dPIKDBPKAOK_;

		// Token: 0x04002E8E RID: 11918
		public const int LFFHDKHBHNNFieldNumber = 15;

		// Token: 0x04002E8F RID: 11919
		private static readonly FieldCodec<uint> _repeated_lFFHDKHBHNN_codec = FieldCodec.ForUInt32(122U);

		// Token: 0x04002E90 RID: 11920
		private readonly RepeatedField<uint> lFFHDKHBHNN_ = new RepeatedField<uint>();

		// Token: 0x04002E91 RID: 11921
		public const int ModifyTimeFieldNumber = 13;

		// Token: 0x04002E92 RID: 11922
		private long modifyTime_;
	}
}
