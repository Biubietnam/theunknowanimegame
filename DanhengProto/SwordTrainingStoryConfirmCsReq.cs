using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001255 RID: 4693
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingStoryConfirmCsReq : IMessage<SwordTrainingStoryConfirmCsReq>, IMessage, IEquatable<SwordTrainingStoryConfirmCsReq>, IDeepCloneable<SwordTrainingStoryConfirmCsReq>, IBufferMessage
	{
		// Token: 0x17003B02 RID: 15106
		// (get) Token: 0x0600D18D RID: 53645 RVA: 0x002306F4 File Offset: 0x0022E8F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingStoryConfirmCsReq> Parser
		{
			get
			{
				return SwordTrainingStoryConfirmCsReq._parser;
			}
		}

		// Token: 0x17003B03 RID: 15107
		// (get) Token: 0x0600D18E RID: 53646 RVA: 0x002306FB File Offset: 0x0022E8FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingStoryConfirmCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003B04 RID: 15108
		// (get) Token: 0x0600D18F RID: 53647 RVA: 0x0023070D File Offset: 0x0022E90D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingStoryConfirmCsReq.Descriptor;
			}
		}

		// Token: 0x0600D190 RID: 53648 RVA: 0x00230714 File Offset: 0x0022E914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingStoryConfirmCsReq()
		{
		}

		// Token: 0x0600D191 RID: 53649 RVA: 0x0023071C File Offset: 0x0022E91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingStoryConfirmCsReq(SwordTrainingStoryConfirmCsReq other) : this()
		{
			this.cOJGEGHIADI_ = other.cOJGEGHIADI_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D192 RID: 53650 RVA: 0x00230741 File Offset: 0x0022E941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingStoryConfirmCsReq Clone()
		{
			return new SwordTrainingStoryConfirmCsReq(this);
		}

		// Token: 0x17003B05 RID: 15109
		// (get) Token: 0x0600D193 RID: 53651 RVA: 0x00230749 File Offset: 0x0022E949
		// (set) Token: 0x0600D194 RID: 53652 RVA: 0x00230751 File Offset: 0x0022E951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint COJGEGHIADI
		{
			get
			{
				return this.cOJGEGHIADI_;
			}
			set
			{
				this.cOJGEGHIADI_ = value;
			}
		}

		// Token: 0x0600D195 RID: 53653 RVA: 0x0023075A File Offset: 0x0022E95A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingStoryConfirmCsReq);
		}

		// Token: 0x0600D196 RID: 53654 RVA: 0x00230768 File Offset: 0x0022E968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingStoryConfirmCsReq other)
		{
			return other != null && (other == this || (this.COJGEGHIADI == other.COJGEGHIADI && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D197 RID: 53655 RVA: 0x00230798 File Offset: 0x0022E998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.COJGEGHIADI != 0U)
			{
				num ^= this.COJGEGHIADI.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D198 RID: 53656 RVA: 0x002307D7 File Offset: 0x0022E9D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D199 RID: 53657 RVA: 0x002307DF File Offset: 0x0022E9DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D19A RID: 53658 RVA: 0x002307E8 File Offset: 0x0022E9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.COJGEGHIADI != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.COJGEGHIADI);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D19B RID: 53659 RVA: 0x0023081C File Offset: 0x0022EA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.COJGEGHIADI != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.COJGEGHIADI);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D19C RID: 53660 RVA: 0x0023085A File Offset: 0x0022EA5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingStoryConfirmCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.COJGEGHIADI != 0U)
			{
				this.COJGEGHIADI = other.COJGEGHIADI;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D19D RID: 53661 RVA: 0x0023088B File Offset: 0x0022EA8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D19E RID: 53662 RVA: 0x00230894 File Offset: 0x0022EA94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.COJGEGHIADI = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04005410 RID: 21520
		private static readonly MessageParser<SwordTrainingStoryConfirmCsReq> _parser = new MessageParser<SwordTrainingStoryConfirmCsReq>(() => new SwordTrainingStoryConfirmCsReq());

		// Token: 0x04005411 RID: 21521
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005412 RID: 21522
		public const int COJGEGHIADIFieldNumber = 14;

		// Token: 0x04005413 RID: 21523
		private uint cOJGEGHIADI_;
	}
}
