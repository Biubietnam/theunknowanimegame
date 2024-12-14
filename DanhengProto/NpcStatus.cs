using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000C39 RID: 3129
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class NpcStatus : IMessage<NpcStatus>, IMessage, IEquatable<NpcStatus>, IDeepCloneable<NpcStatus>, IBufferMessage
	{
		// Token: 0x170026F0 RID: 9968
		// (get) Token: 0x06008AB9 RID: 35513 RVA: 0x0016E758 File Offset: 0x0016C958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NpcStatus> Parser
		{
			get
			{
				return NpcStatus._parser;
			}
		}

		// Token: 0x170026F1 RID: 9969
		// (get) Token: 0x06008ABA RID: 35514 RVA: 0x0016E75F File Offset: 0x0016C95F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NpcStatusReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170026F2 RID: 9970
		// (get) Token: 0x06008ABB RID: 35515 RVA: 0x0016E771 File Offset: 0x0016C971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcStatus.Descriptor;
			}
		}

		// Token: 0x06008ABC RID: 35516 RVA: 0x0016E778 File Offset: 0x0016C978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcStatus()
		{
		}

		// Token: 0x06008ABD RID: 35517 RVA: 0x0016E780 File Offset: 0x0016C980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcStatus(NpcStatus other) : this()
		{
			this.npcId_ = other.npcId_;
			this.isFinish_ = other.isFinish_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008ABE RID: 35518 RVA: 0x0016E7B1 File Offset: 0x0016C9B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcStatus Clone()
		{
			return new NpcStatus(this);
		}

		// Token: 0x170026F3 RID: 9971
		// (get) Token: 0x06008ABF RID: 35519 RVA: 0x0016E7B9 File Offset: 0x0016C9B9
		// (set) Token: 0x06008AC0 RID: 35520 RVA: 0x0016E7C1 File Offset: 0x0016C9C1
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

		// Token: 0x170026F4 RID: 9972
		// (get) Token: 0x06008AC1 RID: 35521 RVA: 0x0016E7CA File Offset: 0x0016C9CA
		// (set) Token: 0x06008AC2 RID: 35522 RVA: 0x0016E7D2 File Offset: 0x0016C9D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinish
		{
			get
			{
				return this.isFinish_;
			}
			set
			{
				this.isFinish_ = value;
			}
		}

		// Token: 0x06008AC3 RID: 35523 RVA: 0x0016E7DB File Offset: 0x0016C9DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcStatus);
		}

		// Token: 0x06008AC4 RID: 35524 RVA: 0x0016E7E9 File Offset: 0x0016C9E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcStatus other)
		{
			return other != null && (other == this || (this.NpcId == other.NpcId && this.IsFinish == other.IsFinish && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008AC5 RID: 35525 RVA: 0x0016E828 File Offset: 0x0016CA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NpcId != 0U)
			{
				num ^= this.NpcId.GetHashCode();
			}
			if (this.IsFinish)
			{
				num ^= this.IsFinish.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008AC6 RID: 35526 RVA: 0x0016E880 File Offset: 0x0016CA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008AC7 RID: 35527 RVA: 0x0016E888 File Offset: 0x0016CA88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008AC8 RID: 35528 RVA: 0x0016E894 File Offset: 0x0016CA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NpcId != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.NpcId);
			}
			if (this.IsFinish)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.IsFinish);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008AC9 RID: 35529 RVA: 0x0016E8F0 File Offset: 0x0016CAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NpcId != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.NpcId);
			}
			if (this.IsFinish)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008ACA RID: 35530 RVA: 0x0016E93C File Offset: 0x0016CB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcStatus other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NpcId != 0U)
			{
				this.NpcId = other.NpcId;
			}
			if (other.IsFinish)
			{
				this.IsFinish = other.IsFinish;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008ACB RID: 35531 RVA: 0x0016E98C File Offset: 0x0016CB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008ACC RID: 35532 RVA: 0x0016E998 File Offset: 0x0016CB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsFinish = input.ReadBool();
					}
				}
				else
				{
					this.NpcId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003539 RID: 13625
		private static readonly MessageParser<NpcStatus> _parser = new MessageParser<NpcStatus>(() => new NpcStatus());

		// Token: 0x0400353A RID: 13626
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400353B RID: 13627
		public const int NpcIdFieldNumber = 4;

		// Token: 0x0400353C RID: 13628
		private uint npcId_;

		// Token: 0x0400353D RID: 13629
		public const int IsFinishFieldNumber = 15;

		// Token: 0x0400353E RID: 13630
		private bool isFinish_;
	}
}
