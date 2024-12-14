using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001325 RID: 4901
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeRogueEndlessActivityPointRewardCsReq : IMessage<TakeRogueEndlessActivityPointRewardCsReq>, IMessage, IEquatable<TakeRogueEndlessActivityPointRewardCsReq>, IDeepCloneable<TakeRogueEndlessActivityPointRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003D6F RID: 15727
		// (get) Token: 0x0600DAAD RID: 55981 RVA: 0x00246769 File Offset: 0x00244969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeRogueEndlessActivityPointRewardCsReq> Parser
		{
			get
			{
				return TakeRogueEndlessActivityPointRewardCsReq._parser;
			}
		}

		// Token: 0x17003D70 RID: 15728
		// (get) Token: 0x0600DAAE RID: 55982 RVA: 0x00246770 File Offset: 0x00244970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeRogueEndlessActivityPointRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003D71 RID: 15729
		// (get) Token: 0x0600DAAF RID: 55983 RVA: 0x00246782 File Offset: 0x00244982
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeRogueEndlessActivityPointRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600DAB0 RID: 55984 RVA: 0x00246789 File Offset: 0x00244989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueEndlessActivityPointRewardCsReq()
		{
		}

		// Token: 0x0600DAB1 RID: 55985 RVA: 0x00246791 File Offset: 0x00244991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueEndlessActivityPointRewardCsReq(TakeRogueEndlessActivityPointRewardCsReq other) : this()
		{
			this.level_ = other.level_;
			this.mGCIACFKBFM_ = other.mGCIACFKBFM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DAB2 RID: 55986 RVA: 0x002467C2 File Offset: 0x002449C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeRogueEndlessActivityPointRewardCsReq Clone()
		{
			return new TakeRogueEndlessActivityPointRewardCsReq(this);
		}

		// Token: 0x17003D72 RID: 15730
		// (get) Token: 0x0600DAB3 RID: 55987 RVA: 0x002467CA File Offset: 0x002449CA
		// (set) Token: 0x0600DAB4 RID: 55988 RVA: 0x002467D2 File Offset: 0x002449D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17003D73 RID: 15731
		// (get) Token: 0x0600DAB5 RID: 55989 RVA: 0x002467DB File Offset: 0x002449DB
		// (set) Token: 0x0600DAB6 RID: 55990 RVA: 0x002467E3 File Offset: 0x002449E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MGCIACFKBFM
		{
			get
			{
				return this.mGCIACFKBFM_;
			}
			set
			{
				this.mGCIACFKBFM_ = value;
			}
		}

		// Token: 0x0600DAB7 RID: 55991 RVA: 0x002467EC File Offset: 0x002449EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeRogueEndlessActivityPointRewardCsReq);
		}

		// Token: 0x0600DAB8 RID: 55992 RVA: 0x002467FA File Offset: 0x002449FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeRogueEndlessActivityPointRewardCsReq other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.MGCIACFKBFM == other.MGCIACFKBFM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DAB9 RID: 55993 RVA: 0x00246838 File Offset: 0x00244A38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.MGCIACFKBFM)
			{
				num ^= this.MGCIACFKBFM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DABA RID: 55994 RVA: 0x00246890 File Offset: 0x00244A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600DABB RID: 55995 RVA: 0x00246898 File Offset: 0x00244A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DABC RID: 55996 RVA: 0x002468A4 File Offset: 0x00244AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Level);
			}
			if (this.MGCIACFKBFM)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.MGCIACFKBFM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DABD RID: 55997 RVA: 0x00246900 File Offset: 0x00244B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.MGCIACFKBFM)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DABE RID: 55998 RVA: 0x0024694C File Offset: 0x00244B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeRogueEndlessActivityPointRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.MGCIACFKBFM)
			{
				this.MGCIACFKBFM = other.MGCIACFKBFM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DABF RID: 55999 RVA: 0x0024699C File Offset: 0x00244B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DAC0 RID: 56000 RVA: 0x002469A8 File Offset: 0x00244BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MGCIACFKBFM = input.ReadBool();
					}
				}
				else
				{
					this.Level = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005713 RID: 22291
		private static readonly MessageParser<TakeRogueEndlessActivityPointRewardCsReq> _parser = new MessageParser<TakeRogueEndlessActivityPointRewardCsReq>(() => new TakeRogueEndlessActivityPointRewardCsReq());

		// Token: 0x04005714 RID: 22292
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005715 RID: 22293
		public const int LevelFieldNumber = 2;

		// Token: 0x04005716 RID: 22294
		private uint level_;

		// Token: 0x04005717 RID: 22295
		public const int MGCIACFKBFMFieldNumber = 10;

		// Token: 0x04005718 RID: 22296
		private bool mGCIACFKBFM_;
	}
}
