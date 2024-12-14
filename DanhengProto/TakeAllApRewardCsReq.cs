using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012AF RID: 4783
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class TakeAllApRewardCsReq : IMessage<TakeAllApRewardCsReq>, IMessage, IEquatable<TakeAllApRewardCsReq>, IDeepCloneable<TakeAllApRewardCsReq>, IBufferMessage
	{
		// Token: 0x17003C02 RID: 15362
		// (get) Token: 0x0600D55D RID: 54621 RVA: 0x00239823 File Offset: 0x00237A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TakeAllApRewardCsReq> Parser
		{
			get
			{
				return TakeAllApRewardCsReq._parser;
			}
		}

		// Token: 0x17003C03 RID: 15363
		// (get) Token: 0x0600D55E RID: 54622 RVA: 0x0023982A File Offset: 0x00237A2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TakeAllApRewardCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003C04 RID: 15364
		// (get) Token: 0x0600D55F RID: 54623 RVA: 0x0023983C File Offset: 0x00237A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TakeAllApRewardCsReq.Descriptor;
			}
		}

		// Token: 0x0600D560 RID: 54624 RVA: 0x00239843 File Offset: 0x00237A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeAllApRewardCsReq()
		{
		}

		// Token: 0x0600D561 RID: 54625 RVA: 0x0023984B File Offset: 0x00237A4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeAllApRewardCsReq(TakeAllApRewardCsReq other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D562 RID: 54626 RVA: 0x00239864 File Offset: 0x00237A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TakeAllApRewardCsReq Clone()
		{
			return new TakeAllApRewardCsReq(this);
		}

		// Token: 0x0600D563 RID: 54627 RVA: 0x0023986C File Offset: 0x00237A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TakeAllApRewardCsReq);
		}

		// Token: 0x0600D564 RID: 54628 RVA: 0x0023987A File Offset: 0x00237A7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TakeAllApRewardCsReq other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D565 RID: 54629 RVA: 0x00239898 File Offset: 0x00237A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D566 RID: 54630 RVA: 0x002398BE File Offset: 0x00237ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D567 RID: 54631 RVA: 0x002398C6 File Offset: 0x00237AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D568 RID: 54632 RVA: 0x002398CF File Offset: 0x00237ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D569 RID: 54633 RVA: 0x002398E8 File Offset: 0x00237AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D56A RID: 54634 RVA: 0x0023990E File Offset: 0x00237B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TakeAllApRewardCsReq other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D56B RID: 54635 RVA: 0x0023992B File Offset: 0x00237B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D56C RID: 54636 RVA: 0x00239934 File Offset: 0x00237B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400554D RID: 21837
		private static readonly MessageParser<TakeAllApRewardCsReq> _parser = new MessageParser<TakeAllApRewardCsReq>(() => new TakeAllApRewardCsReq());

		// Token: 0x0400554E RID: 21838
		private UnknownFieldSet _unknownFields;
	}
}
