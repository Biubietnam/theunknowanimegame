using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020009A7 RID: 2471
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class KIAFEAMDFOE : IMessage<KIAFEAMDFOE>, IMessage, IEquatable<KIAFEAMDFOE>, IDeepCloneable<KIAFEAMDFOE>, IBufferMessage
	{
		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x06006E7D RID: 28285 RVA: 0x00127359 File Offset: 0x00125559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KIAFEAMDFOE> Parser
		{
			get
			{
				return KIAFEAMDFOE._parser;
			}
		}

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x06006E7E RID: 28286 RVA: 0x00127360 File Offset: 0x00125560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return KIAFEAMDFOEReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x06006E7F RID: 28287 RVA: 0x00127372 File Offset: 0x00125572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KIAFEAMDFOE.Descriptor;
			}
		}

		// Token: 0x06006E80 RID: 28288 RVA: 0x00127379 File Offset: 0x00125579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KIAFEAMDFOE()
		{
		}

		// Token: 0x06006E81 RID: 28289 RVA: 0x00127384 File Offset: 0x00125584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KIAFEAMDFOE(KIAFEAMDFOE other) : this()
		{
			this.bOMJHCMJBME_ = ((other.bOMJHCMJBME_ != null) ? other.bOMJHCMJBME_.Clone() : null);
			this.mPOIKGNBKPC_ = other.mPOIKGNBKPC_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E82 RID: 28290 RVA: 0x001273D0 File Offset: 0x001255D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KIAFEAMDFOE Clone()
		{
			return new KIAFEAMDFOE(this);
		}

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x06006E83 RID: 28291 RVA: 0x001273D8 File Offset: 0x001255D8
		// (set) Token: 0x06006E84 RID: 28292 RVA: 0x001273E0 File Offset: 0x001255E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueMagicScepter BOMJHCMJBME
		{
			get
			{
				return this.bOMJHCMJBME_;
			}
			set
			{
				this.bOMJHCMJBME_ = value;
			}
		}

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x06006E85 RID: 28293 RVA: 0x001273E9 File Offset: 0x001255E9
		// (set) Token: 0x06006E86 RID: 28294 RVA: 0x001273F1 File Offset: 0x001255F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool MPOIKGNBKPC
		{
			get
			{
				return this.mPOIKGNBKPC_;
			}
			set
			{
				this.mPOIKGNBKPC_ = value;
			}
		}

		// Token: 0x06006E87 RID: 28295 RVA: 0x001273FA File Offset: 0x001255FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KIAFEAMDFOE);
		}

		// Token: 0x06006E88 RID: 28296 RVA: 0x00127408 File Offset: 0x00125608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KIAFEAMDFOE other)
		{
			return other != null && (other == this || (object.Equals(this.BOMJHCMJBME, other.BOMJHCMJBME) && this.MPOIKGNBKPC == other.MPOIKGNBKPC && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006E89 RID: 28297 RVA: 0x00127458 File Offset: 0x00125658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.bOMJHCMJBME_ != null)
			{
				num ^= this.BOMJHCMJBME.GetHashCode();
			}
			if (this.MPOIKGNBKPC)
			{
				num ^= this.MPOIKGNBKPC.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E8A RID: 28298 RVA: 0x001274AD File Offset: 0x001256AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006E8B RID: 28299 RVA: 0x001274B5 File Offset: 0x001256B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E8C RID: 28300 RVA: 0x001274C0 File Offset: 0x001256C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.bOMJHCMJBME_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.BOMJHCMJBME);
			}
			if (this.MPOIKGNBKPC)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.MPOIKGNBKPC);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E8D RID: 28301 RVA: 0x0012751C File Offset: 0x0012571C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.bOMJHCMJBME_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BOMJHCMJBME);
			}
			if (this.MPOIKGNBKPC)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E8E RID: 28302 RVA: 0x00127568 File Offset: 0x00125768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KIAFEAMDFOE other)
		{
			if (other == null)
			{
				return;
			}
			if (other.bOMJHCMJBME_ != null)
			{
				if (this.bOMJHCMJBME_ == null)
				{
					this.BOMJHCMJBME = new RogueMagicScepter();
				}
				this.BOMJHCMJBME.MergeFrom(other.BOMJHCMJBME);
			}
			if (other.MPOIKGNBKPC)
			{
				this.MPOIKGNBKPC = other.MPOIKGNBKPC;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006E8F RID: 28303 RVA: 0x001275D0 File Offset: 0x001257D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E90 RID: 28304 RVA: 0x001275DC File Offset: 0x001257DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 66U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MPOIKGNBKPC = input.ReadBool();
					}
				}
				else
				{
					if (this.bOMJHCMJBME_ == null)
					{
						this.BOMJHCMJBME = new RogueMagicScepter();
					}
					input.ReadMessage(this.BOMJHCMJBME);
				}
			}
		}

		// Token: 0x04002A70 RID: 10864
		private static readonly MessageParser<KIAFEAMDFOE> _parser = new MessageParser<KIAFEAMDFOE>(() => new KIAFEAMDFOE());

		// Token: 0x04002A71 RID: 10865
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A72 RID: 10866
		public const int BOMJHCMJBMEFieldNumber = 8;

		// Token: 0x04002A73 RID: 10867
		private RogueMagicScepter bOMJHCMJBME_;

		// Token: 0x04002A74 RID: 10868
		public const int MPOIKGNBKPCFieldNumber = 11;

		// Token: 0x04002A75 RID: 10869
		private bool mPOIKGNBKPC_;
	}
}
