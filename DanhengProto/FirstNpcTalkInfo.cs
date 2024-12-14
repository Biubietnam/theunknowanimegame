using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005AB RID: 1451
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FirstNpcTalkInfo : IMessage<FirstNpcTalkInfo>, IMessage, IEquatable<FirstNpcTalkInfo>, IDeepCloneable<FirstNpcTalkInfo>, IBufferMessage
	{
		// Token: 0x17001268 RID: 4712
		// (get) Token: 0x060040C8 RID: 16584 RVA: 0x000B06E8 File Offset: 0x000AE8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FirstNpcTalkInfo> Parser
		{
			get
			{
				return FirstNpcTalkInfo._parser;
			}
		}

		// Token: 0x17001269 RID: 4713
		// (get) Token: 0x060040C9 RID: 16585 RVA: 0x000B06EF File Offset: 0x000AE8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FirstNpcTalkInfoReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700126A RID: 4714
		// (get) Token: 0x060040CA RID: 16586 RVA: 0x000B0701 File Offset: 0x000AE901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FirstNpcTalkInfo.Descriptor;
			}
		}

		// Token: 0x060040CB RID: 16587 RVA: 0x000B0708 File Offset: 0x000AE908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FirstNpcTalkInfo()
		{
		}

		// Token: 0x060040CC RID: 16588 RVA: 0x000B0710 File Offset: 0x000AE910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FirstNpcTalkInfo(FirstNpcTalkInfo other) : this()
		{
			this.npcId_ = other.npcId_;
			this.isMeet_ = other.isMeet_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060040CD RID: 16589 RVA: 0x000B0741 File Offset: 0x000AE941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FirstNpcTalkInfo Clone()
		{
			return new FirstNpcTalkInfo(this);
		}

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x060040CE RID: 16590 RVA: 0x000B0749 File Offset: 0x000AE949
		// (set) Token: 0x060040CF RID: 16591 RVA: 0x000B0751 File Offset: 0x000AE951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint NpcId
		{
			get
			{
				return this.npcId_;
			}
			set
			{
				this.npcId_ = value;
			}
		}

		// Token: 0x1700126C RID: 4716
		// (get) Token: 0x060040D0 RID: 16592 RVA: 0x000B075A File Offset: 0x000AE95A
		// (set) Token: 0x060040D1 RID: 16593 RVA: 0x000B0762 File Offset: 0x000AE962
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsMeet
		{
			get
			{
				return this.isMeet_;
			}
			set
			{
				this.isMeet_ = value;
			}
		}

		// Token: 0x060040D2 RID: 16594 RVA: 0x000B076B File Offset: 0x000AE96B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FirstNpcTalkInfo);
		}

		// Token: 0x060040D3 RID: 16595 RVA: 0x000B0779 File Offset: 0x000AE979
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FirstNpcTalkInfo other)
		{
			return other != null && (other == this || (this.NpcId == other.NpcId && this.IsMeet == other.IsMeet && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060040D4 RID: 16596 RVA: 0x000B07B8 File Offset: 0x000AE9B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NpcId != 0U)
			{
				num ^= this.NpcId.GetHashCode();
			}
			if (this.IsMeet)
			{
				num ^= this.IsMeet.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060040D5 RID: 16597 RVA: 0x000B0810 File Offset: 0x000AEA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060040D6 RID: 16598 RVA: 0x000B0818 File Offset: 0x000AEA18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060040D7 RID: 16599 RVA: 0x000B0824 File Offset: 0x000AEA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsMeet)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsMeet);
			}
			if (this.NpcId != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.NpcId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060040D8 RID: 16600 RVA: 0x000B0880 File Offset: 0x000AEA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NpcId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NpcId);
			}
			if (this.IsMeet)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060040D9 RID: 16601 RVA: 0x000B08CC File Offset: 0x000AEACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FirstNpcTalkInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NpcId != 0U)
			{
				this.NpcId = other.NpcId;
			}
			if (other.IsMeet)
			{
				this.IsMeet = other.IsMeet;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060040DA RID: 16602 RVA: 0x000B091C File Offset: 0x000AEB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060040DB RID: 16603 RVA: 0x000B0928 File Offset: 0x000AEB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NpcId = input.ReadUInt32();
					}
				}
				else
				{
					this.IsMeet = input.ReadBool();
				}
			}
		}

		// Token: 0x040019B3 RID: 6579
		private static readonly MessageParser<FirstNpcTalkInfo> _parser = new MessageParser<FirstNpcTalkInfo>(() => new FirstNpcTalkInfo());

		// Token: 0x040019B4 RID: 6580
		private UnknownFieldSet _unknownFields;

		// Token: 0x040019B5 RID: 6581
		public const int NpcIdFieldNumber = 7;

		// Token: 0x040019B6 RID: 6582
		private uint npcId_;

		// Token: 0x040019B7 RID: 6583
		public const int IsMeetFieldNumber = 4;

		// Token: 0x040019B8 RID: 6584
		private bool isMeet_;
	}
}
