using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000591 RID: 1425
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class FinishQuestScRsp : IMessage<FinishQuestScRsp>, IMessage, IEquatable<FinishQuestScRsp>, IDeepCloneable<FinishQuestScRsp>, IBufferMessage
	{
		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x06003F9A RID: 16282 RVA: 0x000AD830 File Offset: 0x000ABA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FinishQuestScRsp> Parser
		{
			get
			{
				return FinishQuestScRsp._parser;
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x06003F9B RID: 16283 RVA: 0x000AD837 File Offset: 0x000ABA37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return FinishQuestScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x06003F9C RID: 16284 RVA: 0x000AD849 File Offset: 0x000ABA49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FinishQuestScRsp.Descriptor;
			}
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x000AD850 File Offset: 0x000ABA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishQuestScRsp()
		{
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x000AD858 File Offset: 0x000ABA58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishQuestScRsp(FinishQuestScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x000AD87D File Offset: 0x000ABA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FinishQuestScRsp Clone()
		{
			return new FinishQuestScRsp(this);
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x06003FA0 RID: 16288 RVA: 0x000AD885 File Offset: 0x000ABA85
		// (set) Token: 0x06003FA1 RID: 16289 RVA: 0x000AD88D File Offset: 0x000ABA8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x000AD896 File Offset: 0x000ABA96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FinishQuestScRsp);
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x000AD8A4 File Offset: 0x000ABAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FinishQuestScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x000AD8D4 File Offset: 0x000ABAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x000AD913 File Offset: 0x000ABB13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x000AD91B File Offset: 0x000ABB1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x000AD924 File Offset: 0x000ABB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x000AD958 File Offset: 0x000ABB58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x000AD996 File Offset: 0x000ABB96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FinishQuestScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003FAA RID: 16298 RVA: 0x000AD9C7 File Offset: 0x000ABBC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003FAB RID: 16299 RVA: 0x000AD9D0 File Offset: 0x000ABBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x0400194F RID: 6479
		private static readonly MessageParser<FinishQuestScRsp> _parser = new MessageParser<FinishQuestScRsp>(() => new FinishQuestScRsp());

		// Token: 0x04001950 RID: 6480
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001951 RID: 6481
		public const int RetcodeFieldNumber = 4;

		// Token: 0x04001952 RID: 6482
		private uint retcode_;
	}
}
