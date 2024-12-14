using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010FD RID: 4349
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetGenderCsReq : IMessage<SetGenderCsReq>, IMessage, IEquatable<SetGenderCsReq>, IDeepCloneable<SetGenderCsReq>, IBufferMessage
	{
		// Token: 0x170036B5 RID: 14005
		// (get) Token: 0x0600C1EA RID: 49642 RVA: 0x00209150 File Offset: 0x00207350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetGenderCsReq> Parser
		{
			get
			{
				return SetGenderCsReq._parser;
			}
		}

		// Token: 0x170036B6 RID: 14006
		// (get) Token: 0x0600C1EB RID: 49643 RVA: 0x00209157 File Offset: 0x00207357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetGenderCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170036B7 RID: 14007
		// (get) Token: 0x0600C1EC RID: 49644 RVA: 0x00209169 File Offset: 0x00207369
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetGenderCsReq.Descriptor;
			}
		}

		// Token: 0x0600C1ED RID: 49645 RVA: 0x00209170 File Offset: 0x00207370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetGenderCsReq()
		{
		}

		// Token: 0x0600C1EE RID: 49646 RVA: 0x00209178 File Offset: 0x00207378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetGenderCsReq(SetGenderCsReq other) : this()
		{
			this.gender_ = other.gender_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C1EF RID: 49647 RVA: 0x0020919D File Offset: 0x0020739D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetGenderCsReq Clone()
		{
			return new SetGenderCsReq(this);
		}

		// Token: 0x170036B8 RID: 14008
		// (get) Token: 0x0600C1F0 RID: 49648 RVA: 0x002091A5 File Offset: 0x002073A5
		// (set) Token: 0x0600C1F1 RID: 49649 RVA: 0x002091AD File Offset: 0x002073AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Gender Gender
		{
			get
			{
				return this.gender_;
			}
			set
			{
				this.gender_ = value;
			}
		}

		// Token: 0x0600C1F2 RID: 49650 RVA: 0x002091B6 File Offset: 0x002073B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetGenderCsReq);
		}

		// Token: 0x0600C1F3 RID: 49651 RVA: 0x002091C4 File Offset: 0x002073C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetGenderCsReq other)
		{
			return other != null && (other == this || (this.Gender == other.Gender && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C1F4 RID: 49652 RVA: 0x002091F4 File Offset: 0x002073F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Gender != Gender.None)
			{
				num ^= this.Gender.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C1F5 RID: 49653 RVA: 0x00209239 File Offset: 0x00207439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C1F6 RID: 49654 RVA: 0x00209241 File Offset: 0x00207441
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C1F7 RID: 49655 RVA: 0x0020924A File Offset: 0x0020744A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Gender != Gender.None)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Gender);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C1F8 RID: 49656 RVA: 0x0020927C File Offset: 0x0020747C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Gender != Gender.None)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Gender);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C1F9 RID: 49657 RVA: 0x002092BA File Offset: 0x002074BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetGenderCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Gender != Gender.None)
			{
				this.Gender = other.Gender;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C1FA RID: 49658 RVA: 0x002092EB File Offset: 0x002074EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C1FB RID: 49659 RVA: 0x002092F4 File Offset: 0x002074F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Gender = (Gender)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004E7D RID: 20093
		private static readonly MessageParser<SetGenderCsReq> _parser = new MessageParser<SetGenderCsReq>(() => new SetGenderCsReq());

		// Token: 0x04004E7E RID: 20094
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E7F RID: 20095
		public const int GenderFieldNumber = 15;

		// Token: 0x04004E80 RID: 20096
		private Gender gender_;
	}
}
