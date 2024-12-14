using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000045 RID: 69
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class AddEquipmentScNotify : IMessage<AddEquipmentScNotify>, IMessage, IEquatable<AddEquipmentScNotify>, IDeepCloneable<AddEquipmentScNotify>, IBufferMessage
	{
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002AF RID: 687 RVA: 0x00008894 File Offset: 0x00006A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AddEquipmentScNotify> Parser
		{
			get
			{
				return AddEquipmentScNotify._parser;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000889B File Offset: 0x00006A9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AddEquipmentScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x000088AD File Offset: 0x00006AAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddEquipmentScNotify.Descriptor;
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x000088B4 File Offset: 0x00006AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddEquipmentScNotify()
		{
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000088BC File Offset: 0x00006ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddEquipmentScNotify(AddEquipmentScNotify other) : this()
		{
			this.eGNDMKMFPIN_ = other.eGNDMKMFPIN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000088E1 File Offset: 0x00006AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddEquipmentScNotify Clone()
		{
			return new AddEquipmentScNotify(this);
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x000088E9 File Offset: 0x00006AE9
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x000088F1 File Offset: 0x00006AF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EGNDMKMFPIN
		{
			get
			{
				return this.eGNDMKMFPIN_;
			}
			set
			{
				this.eGNDMKMFPIN_ = value;
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000088FA File Offset: 0x00006AFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddEquipmentScNotify);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00008908 File Offset: 0x00006B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddEquipmentScNotify other)
		{
			return other != null && (other == this || (this.EGNDMKMFPIN == other.EGNDMKMFPIN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00008938 File Offset: 0x00006B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EGNDMKMFPIN != 0U)
			{
				num ^= this.EGNDMKMFPIN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00008977 File Offset: 0x00006B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000897F File Offset: 0x00006B7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00008988 File Offset: 0x00006B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EGNDMKMFPIN != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.EGNDMKMFPIN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000089BC File Offset: 0x00006BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EGNDMKMFPIN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EGNDMKMFPIN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000089FA File Offset: 0x00006BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddEquipmentScNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EGNDMKMFPIN != 0U)
			{
				this.EGNDMKMFPIN = other.EGNDMKMFPIN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00008A2B File Offset: 0x00006C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00008A34 File Offset: 0x00006C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EGNDMKMFPIN = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040000F7 RID: 247
		private static readonly MessageParser<AddEquipmentScNotify> _parser = new MessageParser<AddEquipmentScNotify>(() => new AddEquipmentScNotify());

		// Token: 0x040000F8 RID: 248
		private UnknownFieldSet _unknownFields;

		// Token: 0x040000F9 RID: 249
		public const int EGNDMKMFPINFieldNumber = 9;

		// Token: 0x040000FA RID: 250
		private uint eGNDMKMFPIN_;
	}
}
