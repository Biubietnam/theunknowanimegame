using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012AB RID: 4779
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeActivityExpeditionRewardCsReq : IMessage<TakeActivityExpeditionRewardCsReq>, IMessage, IEquatable<TakeActivityExpeditionRewardCsReq>, IDeepCloneable<TakeActivityExpeditionRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003BF4 RID: 15348
		// (get) Token: 0x0600D52B RID: 54571 RVA: 0x00238FC9 File Offset: 0x002371C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeActivityExpeditionRewardCsReq> Parser
		{
			get
			{
				return TakeActivityExpeditionRewardCsReq._parser;
			}
		}

		// Token: 0x17003BF5 RID: 15349
		// (get) Token: 0x0600D52C RID: 54572 RVA: 0x00238FD0 File Offset: 0x002371D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeActivityExpeditionRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BF6 RID: 15350
		// (get) Token: 0x0600D52D RID: 54573 RVA: 0x00238FE2 File Offset: 0x002371E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeActivityExpeditionRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D52E RID: 54574 RVA: 0x00238FE9 File Offset: 0x002371E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeActivityExpeditionRewardCsReq()
		{
		}

		// Token: 0x0600D52F RID: 54575 RVA: 0x00238FF1 File Offset: 0x002371F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeActivityExpeditionRewardCsReq(TakeActivityExpeditionRewardCsReq other) : this()
		{
			this.hADKPJOKKCM_ = other.hADKPJOKKCM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D530 RID: 54576 RVA: 0x00239016 File Offset: 0x00237216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeActivityExpeditionRewardCsReq Clone()
		{
			return new TakeActivityExpeditionRewardCsReq(this);
		}

		// Token: 0x17003BF7 RID: 15351
		// (get) Token: 0x0600D531 RID: 54577 RVA: 0x0023901E File Offset: 0x0023721E
		// (set) Token: 0x0600D532 RID: 54578 RVA: 0x00239026 File Offset: 0x00237226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint HADKPJOKKCM
		{
			get
			{
				return this.hADKPJOKKCM_;
			}
			set
			{
				this.hADKPJOKKCM_ = value;
			}
		}

		// Token: 0x0600D533 RID: 54579 RVA: 0x0023902F File Offset: 0x0023722F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeActivityExpeditionRewardCsReq);
		}

		// Token: 0x0600D534 RID: 54580 RVA: 0x0023903D File Offset: 0x0023723D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeActivityExpeditionRewardCsReq other)
		{
			return other != null && (other == this || (this.HADKPJOKKCM == other.HADKPJOKKCM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D535 RID: 54581 RVA: 0x0023906C File Offset: 0x0023726C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HADKPJOKKCM != 0U)
			{
				num ^= this.HADKPJOKKCM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D536 RID: 54582 RVA: 0x002390AB File Offset: 0x002372AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D537 RID: 54583 RVA: 0x002390B3 File Offset: 0x002372B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D538 RID: 54584 RVA: 0x002390BC File Offset: 0x002372BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HADKPJOKKCM != 0U)
			{
				output.WriteRawTag(96);
				output.WriteUInt32(this.HADKPJOKKCM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D539 RID: 54585 RVA: 0x002390F0 File Offset: 0x002372F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HADKPJOKKCM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.HADKPJOKKCM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D53A RID: 54586 RVA: 0x0023912E File Offset: 0x0023732E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeActivityExpeditionRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HADKPJOKKCM != 0U)
			{
				this.HADKPJOKKCM = other.HADKPJOKKCM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D53B RID: 54587 RVA: 0x0023915F File Offset: 0x0023735F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D53C RID: 54588 RVA: 0x00239168 File Offset: 0x00237368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HADKPJOKKCM = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400553B RID: 21819
		private static readonly MessageParser<TakeActivityExpeditionRewardCsReq> _parser = new MessageParser<TakeActivityExpeditionRewardCsReq>(() => new TakeActivityExpeditionRewardCsReq());

		// Token: 0x0400553C RID: 21820
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400553D RID: 21821
		public const int HADKPJOKKCMFieldNumber = 12;

		// Token: 0x0400553E RID: 21822
		private uint hADKPJOKKCM_;
	}
}
