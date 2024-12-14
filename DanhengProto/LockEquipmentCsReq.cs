using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A55 RID: 2645
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class LockEquipmentCsReq : IMessage<LockEquipmentCsReq>, IMessage, IEquatable<LockEquipmentCsReq>, IDeepCloneable<LockEquipmentCsReq>, IBufferMessage
	{
		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x06007546 RID: 30022 RVA: 0x001378C5 File Offset: 0x00135AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LockEquipmentCsReq> Parser
		{
			get
			{
				return LockEquipmentCsReq._parser;
			}
		}

		// Token: 0x170020F5 RID: 8437
		// (get) Token: 0x06007547 RID: 30023 RVA: 0x001378CC File Offset: 0x00135ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return LockEquipmentCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170020F6 RID: 8438
		// (get) Token: 0x06007548 RID: 30024 RVA: 0x001378DE File Offset: 0x00135ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LockEquipmentCsReq.Descriptor;
			}
		}

		// Token: 0x06007549 RID: 30025 RVA: 0x001378E5 File Offset: 0x00135AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LockEquipmentCsReq()
		{
		}

		// Token: 0x0600754A RID: 30026 RVA: 0x001378F8 File Offset: 0x00135AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LockEquipmentCsReq(LockEquipmentCsReq other) : this()
		{
			this.isProtected_ = other.isProtected_;
			this.equipmentIdList_ = other.equipmentIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600754B RID: 30027 RVA: 0x0013792E File Offset: 0x00135B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LockEquipmentCsReq Clone()
		{
			return new LockEquipmentCsReq(this);
		}

		// Token: 0x170020F7 RID: 8439
		// (get) Token: 0x0600754C RID: 30028 RVA: 0x00137936 File Offset: 0x00135B36
		// (set) Token: 0x0600754D RID: 30029 RVA: 0x0013793E File Offset: 0x00135B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsProtected
		{
			get
			{
				return this.isProtected_;
			}
			set
			{
				this.isProtected_ = value;
			}
		}

		// Token: 0x170020F8 RID: 8440
		// (get) Token: 0x0600754E RID: 30030 RVA: 0x00137947 File Offset: 0x00135B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<uint> EquipmentIdList
		{
			get
			{
				return this.equipmentIdList_;
			}
		}

		// Token: 0x0600754F RID: 30031 RVA: 0x0013794F File Offset: 0x00135B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LockEquipmentCsReq);
		}

		// Token: 0x06007550 RID: 30032 RVA: 0x00137960 File Offset: 0x00135B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LockEquipmentCsReq other)
		{
			return other != null && (other == this || (this.IsProtected == other.IsProtected && this.equipmentIdList_.Equals(other.equipmentIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007551 RID: 30033 RVA: 0x001379B0 File Offset: 0x00135BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsProtected)
			{
				num ^= this.IsProtected.GetHashCode();
			}
			num ^= this.equipmentIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007552 RID: 30034 RVA: 0x001379FD File Offset: 0x00135BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007553 RID: 30035 RVA: 0x00137A05 File Offset: 0x00135C05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007554 RID: 30036 RVA: 0x00137A10 File Offset: 0x00135C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsProtected)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsProtected);
			}
			this.equipmentIdList_.WriteTo(ref output, LockEquipmentCsReq._repeated_equipmentIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007555 RID: 30037 RVA: 0x00137A60 File Offset: 0x00135C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsProtected)
			{
				num += 2;
			}
			num += this.equipmentIdList_.CalculateSize(LockEquipmentCsReq._repeated_equipmentIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007556 RID: 30038 RVA: 0x00137AA8 File Offset: 0x00135CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LockEquipmentCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsProtected)
			{
				this.IsProtected = other.IsProtected;
			}
			this.equipmentIdList_.Add(other.equipmentIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007557 RID: 30039 RVA: 0x00137AF5 File Offset: 0x00135CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007558 RID: 30040 RVA: 0x00137B00 File Offset: 0x00135D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 64U && num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.equipmentIdList_.AddEntriesFrom(ref input, LockEquipmentCsReq._repeated_equipmentIdList_codec);
					}
				}
				else
				{
					this.IsProtected = input.ReadBool();
				}
			}
		}

		// Token: 0x04002D1E RID: 11550
		private static readonly MessageParser<LockEquipmentCsReq> _parser = new MessageParser<LockEquipmentCsReq>(() => new LockEquipmentCsReq());

		// Token: 0x04002D1F RID: 11551
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D20 RID: 11552
		public const int IsProtectedFieldNumber = 3;

		// Token: 0x04002D21 RID: 11553
		private bool isProtected_;

		// Token: 0x04002D22 RID: 11554
		public const int EquipmentIdListFieldNumber = 8;

		// Token: 0x04002D23 RID: 11555
		private static readonly FieldCodec<uint> _repeated_equipmentIdList_codec = FieldCodec.ForUInt32(66U);

		// Token: 0x04002D24 RID: 11556
		private readonly RepeatedField<uint> equipmentIdList_ = new RepeatedField<uint>();
	}
}
