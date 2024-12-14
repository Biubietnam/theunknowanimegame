using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000933 RID: 2355
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class InteractChargerCsReq : IMessage<InteractChargerCsReq>, IMessage, IEquatable<InteractChargerCsReq>, IDeepCloneable<InteractChargerCsReq>, IBufferMessage
	{
		// Token: 0x17001D8D RID: 7565
		// (get) Token: 0x06006912 RID: 26898 RVA: 0x001188B5 File Offset: 0x00116AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<InteractChargerCsReq> Parser
		{
			get
			{
				return InteractChargerCsReq._parser;
			}
		}

		// Token: 0x17001D8E RID: 7566
		// (get) Token: 0x06006913 RID: 26899 RVA: 0x001188BC File Offset: 0x00116ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return InteractChargerCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D8F RID: 7567
		// (get) Token: 0x06006914 RID: 26900 RVA: 0x001188CE File Offset: 0x00116ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InteractChargerCsReq.Descriptor;
			}
		}

		// Token: 0x06006915 RID: 26901 RVA: 0x001188D5 File Offset: 0x00116AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractChargerCsReq()
		{
		}

		// Token: 0x06006916 RID: 26902 RVA: 0x001188DD File Offset: 0x00116ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractChargerCsReq(InteractChargerCsReq other) : this()
		{
			this.chargerInfo_ = ((other.chargerInfo_ != null) ? other.chargerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006917 RID: 26903 RVA: 0x00118912 File Offset: 0x00116B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractChargerCsReq Clone()
		{
			return new InteractChargerCsReq(this);
		}

		// Token: 0x17001D90 RID: 7568
		// (get) Token: 0x06006918 RID: 26904 RVA: 0x0011891A File Offset: 0x00116B1A
		// (set) Token: 0x06006919 RID: 26905 RVA: 0x00118922 File Offset: 0x00116B22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChargerInfo ChargerInfo
		{
			get
			{
				return this.chargerInfo_;
			}
			set
			{
				this.chargerInfo_ = value;
			}
		}

		// Token: 0x0600691A RID: 26906 RVA: 0x0011892B File Offset: 0x00116B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InteractChargerCsReq);
		}

		// Token: 0x0600691B RID: 26907 RVA: 0x00118939 File Offset: 0x00116B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InteractChargerCsReq other)
		{
			return other != null && (other == this || (object.Equals(this.ChargerInfo, other.ChargerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600691C RID: 26908 RVA: 0x0011896C File Offset: 0x00116B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.chargerInfo_ != null)
			{
				num ^= this.ChargerInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600691D RID: 26909 RVA: 0x001189A8 File Offset: 0x00116BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600691E RID: 26910 RVA: 0x001189B0 File Offset: 0x00116BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600691F RID: 26911 RVA: 0x001189B9 File Offset: 0x00116BB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.chargerInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.ChargerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006920 RID: 26912 RVA: 0x001189EC File Offset: 0x00116BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.chargerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChargerInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006921 RID: 26913 RVA: 0x00118A2C File Offset: 0x00116C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InteractChargerCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.chargerInfo_ != null)
			{
				if (this.chargerInfo_ == null)
				{
					this.ChargerInfo = new ChargerInfo();
				}
				this.ChargerInfo.MergeFrom(other.ChargerInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006922 RID: 26914 RVA: 0x00118A80 File Offset: 0x00116C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006923 RID: 26915 RVA: 0x00118A8C File Offset: 0x00116C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.chargerInfo_ == null)
					{
						this.ChargerInfo = new ChargerInfo();
					}
					input.ReadMessage(this.ChargerInfo);
				}
			}
		}

		// Token: 0x0400284A RID: 10314
		private static readonly MessageParser<InteractChargerCsReq> _parser = new MessageParser<InteractChargerCsReq>(() => new InteractChargerCsReq());

		// Token: 0x0400284B RID: 10315
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400284C RID: 10316
		public const int ChargerInfoFieldNumber = 7;

		// Token: 0x0400284D RID: 10317
		private ChargerInfo chargerInfo_;
	}
}
