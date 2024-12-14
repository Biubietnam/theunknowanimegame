using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200033B RID: 827
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class CurAssistChangedNotify : IMessage<CurAssistChangedNotify>, IMessage, IEquatable<CurAssistChangedNotify>, IDeepCloneable<CurAssistChangedNotify>, IBufferMessage
	{
		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x060024F3 RID: 9459 RVA: 0x00068471 File Offset: 0x00066671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<CurAssistChangedNotify> Parser
		{
			get
			{
				return CurAssistChangedNotify._parser;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x060024F4 RID: 9460 RVA: 0x00068478 File Offset: 0x00066678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return CurAssistChangedNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x0006848A File Offset: 0x0006668A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CurAssistChangedNotify.Descriptor;
			}
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x00068491 File Offset: 0x00066691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CurAssistChangedNotify()
		{
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x00068499 File Offset: 0x00066699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CurAssistChangedNotify(CurAssistChangedNotify other) : this()
		{
			this.fRIENDAPPLYSOURCEASSIST_ = ((other.fRIENDAPPLYSOURCEASSIST_ != null) ? other.fRIENDAPPLYSOURCEASSIST_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x000684CE File Offset: 0x000666CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CurAssistChangedNotify Clone()
		{
			return new CurAssistChangedNotify(this);
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x060024F9 RID: 9465 RVA: 0x000684D6 File Offset: 0x000666D6
		// (set) Token: 0x060024FA RID: 9466 RVA: 0x000684DE File Offset: 0x000666DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerAssistInfo FRIENDAPPLYSOURCEASSIST
		{
			get
			{
				return this.fRIENDAPPLYSOURCEASSIST_;
			}
			set
			{
				this.fRIENDAPPLYSOURCEASSIST_ = value;
			}
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x000684E7 File Offset: 0x000666E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CurAssistChangedNotify);
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x000684F5 File Offset: 0x000666F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CurAssistChangedNotify other)
		{
			return other != null && (other == this || (object.Equals(this.FRIENDAPPLYSOURCEASSIST, other.FRIENDAPPLYSOURCEASSIST) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x00068528 File Offset: 0x00066728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.fRIENDAPPLYSOURCEASSIST_ != null)
			{
				num ^= this.FRIENDAPPLYSOURCEASSIST.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x00068564 File Offset: 0x00066764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x0006856C File Offset: 0x0006676C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002500 RID: 9472 RVA: 0x00068575 File Offset: 0x00066775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fRIENDAPPLYSOURCEASSIST_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.FRIENDAPPLYSOURCEASSIST);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002501 RID: 9473 RVA: 0x000685A8 File Offset: 0x000667A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.fRIENDAPPLYSOURCEASSIST_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FRIENDAPPLYSOURCEASSIST);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002502 RID: 9474 RVA: 0x000685E8 File Offset: 0x000667E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CurAssistChangedNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.fRIENDAPPLYSOURCEASSIST_ != null)
			{
				if (this.fRIENDAPPLYSOURCEASSIST_ == null)
				{
					this.FRIENDAPPLYSOURCEASSIST = new PlayerAssistInfo();
				}
				this.FRIENDAPPLYSOURCEASSIST.MergeFrom(other.FRIENDAPPLYSOURCEASSIST);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x0006863C File Offset: 0x0006683C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x00068648 File Offset: 0x00066848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.fRIENDAPPLYSOURCEASSIST_ == null)
					{
						this.FRIENDAPPLYSOURCEASSIST = new PlayerAssistInfo();
					}
					input.ReadMessage(this.FRIENDAPPLYSOURCEASSIST);
				}
			}
		}

		// Token: 0x04000F0D RID: 3853
		private static readonly MessageParser<CurAssistChangedNotify> _parser = new MessageParser<CurAssistChangedNotify>(() => new CurAssistChangedNotify());

		// Token: 0x04000F0E RID: 3854
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F0F RID: 3855
		public const int FRIENDAPPLYSOURCEASSISTFieldNumber = 13;

		// Token: 0x04000F10 RID: 3856
		private PlayerAssistInfo fRIENDAPPLYSOURCEASSIST_;
	}
}
