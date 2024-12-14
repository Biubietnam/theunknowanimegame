using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010F9 RID: 4345
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SetGameplayBirthdayCsReq : IMessage<SetGameplayBirthdayCsReq>, IMessage, IEquatable<SetGameplayBirthdayCsReq>, IDeepCloneable<SetGameplayBirthdayCsReq>, IBufferMessage
	{
		// Token: 0x170036AA RID: 13994
		// (get) Token: 0x0600C1BE RID: 49598 RVA: 0x00208BA4 File Offset: 0x00206DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SetGameplayBirthdayCsReq> Parser
		{
			get
			{
				return SetGameplayBirthdayCsReq._parser;
			}
		}

		// Token: 0x170036AB RID: 13995
		// (get) Token: 0x0600C1BF RID: 49599 RVA: 0x00208BAB File Offset: 0x00206DAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SetGameplayBirthdayCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170036AC RID: 13996
		// (get) Token: 0x0600C1C0 RID: 49600 RVA: 0x00208BBD File Offset: 0x00206DBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetGameplayBirthdayCsReq.Descriptor;
			}
		}

		// Token: 0x0600C1C1 RID: 49601 RVA: 0x00208BC4 File Offset: 0x00206DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetGameplayBirthdayCsReq()
		{
		}

		// Token: 0x0600C1C2 RID: 49602 RVA: 0x00208BCC File Offset: 0x00206DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetGameplayBirthdayCsReq(SetGameplayBirthdayCsReq other) : this()
		{
			this.birthday_ = other.birthday_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C1C3 RID: 49603 RVA: 0x00208BF1 File Offset: 0x00206DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetGameplayBirthdayCsReq Clone()
		{
			return new SetGameplayBirthdayCsReq(this);
		}

		// Token: 0x170036AD RID: 13997
		// (get) Token: 0x0600C1C4 RID: 49604 RVA: 0x00208BF9 File Offset: 0x00206DF9
		// (set) Token: 0x0600C1C5 RID: 49605 RVA: 0x00208C01 File Offset: 0x00206E01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Birthday
		{
			get
			{
				return this.birthday_;
			}
			set
			{
				this.birthday_ = value;
			}
		}

		// Token: 0x0600C1C6 RID: 49606 RVA: 0x00208C0A File Offset: 0x00206E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetGameplayBirthdayCsReq);
		}

		// Token: 0x0600C1C7 RID: 49607 RVA: 0x00208C18 File Offset: 0x00206E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetGameplayBirthdayCsReq other)
		{
			return other != null && (other == this || (this.Birthday == other.Birthday && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C1C8 RID: 49608 RVA: 0x00208C48 File Offset: 0x00206E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Birthday != 0U)
			{
				num ^= this.Birthday.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C1C9 RID: 49609 RVA: 0x00208C87 File Offset: 0x00206E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600C1CA RID: 49610 RVA: 0x00208C8F File Offset: 0x00206E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C1CB RID: 49611 RVA: 0x00208C98 File Offset: 0x00206E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Birthday != 0U)
			{
				output.WriteRawTag(104);
				output.WriteUInt32(this.Birthday);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C1CC RID: 49612 RVA: 0x00208CCC File Offset: 0x00206ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Birthday != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Birthday);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C1CD RID: 49613 RVA: 0x00208D0A File Offset: 0x00206F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetGameplayBirthdayCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Birthday != 0U)
			{
				this.Birthday = other.Birthday;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C1CE RID: 49614 RVA: 0x00208D3B File Offset: 0x00206F3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C1CF RID: 49615 RVA: 0x00208D44 File Offset: 0x00206F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Birthday = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004E71 RID: 20081
		private static readonly MessageParser<SetGameplayBirthdayCsReq> _parser = new MessageParser<SetGameplayBirthdayCsReq>(() => new SetGameplayBirthdayCsReq());

		// Token: 0x04004E72 RID: 20082
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E73 RID: 20083
		public const int BirthdayFieldNumber = 13;

		// Token: 0x04004E74 RID: 20084
		private uint birthday_;
	}
}
