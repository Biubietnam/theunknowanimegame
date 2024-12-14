using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001245 RID: 4677
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SwordTrainingSelectEndingCsReq : IMessage<SwordTrainingSelectEndingCsReq>, IMessage, IEquatable<SwordTrainingSelectEndingCsReq>, IDeepCloneable<SwordTrainingSelectEndingCsReq>, IBufferMessage
	{
		// Token: 0x17003AD7 RID: 15063
		// (get) Token: 0x0600D0DF RID: 53471 RVA: 0x0022F03C File Offset: 0x0022D23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SwordTrainingSelectEndingCsReq> Parser
		{
			get
			{
				return SwordTrainingSelectEndingCsReq._parser;
			}
		}

		// Token: 0x17003AD8 RID: 15064
		// (get) Token: 0x0600D0E0 RID: 53472 RVA: 0x0022F043 File Offset: 0x0022D243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SwordTrainingSelectEndingCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003AD9 RID: 15065
		// (get) Token: 0x0600D0E1 RID: 53473 RVA: 0x0022F055 File Offset: 0x0022D255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwordTrainingSelectEndingCsReq.Descriptor;
			}
		}

		// Token: 0x0600D0E2 RID: 53474 RVA: 0x0022F05C File Offset: 0x0022D25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingSelectEndingCsReq()
		{
		}

		// Token: 0x0600D0E3 RID: 53475 RVA: 0x0022F064 File Offset: 0x0022D264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingSelectEndingCsReq(SwordTrainingSelectEndingCsReq other) : this()
		{
			this.aMDMIAEJNEM_ = other.aMDMIAEJNEM_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D0E4 RID: 53476 RVA: 0x0022F089 File Offset: 0x0022D289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwordTrainingSelectEndingCsReq Clone()
		{
			return new SwordTrainingSelectEndingCsReq(this);
		}

		// Token: 0x17003ADA RID: 15066
		// (get) Token: 0x0600D0E5 RID: 53477 RVA: 0x0022F091 File Offset: 0x0022D291
		// (set) Token: 0x0600D0E6 RID: 53478 RVA: 0x0022F099 File Offset: 0x0022D299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint AMDMIAEJNEM
		{
			get
			{
				return this.aMDMIAEJNEM_;
			}
			set
			{
				this.aMDMIAEJNEM_ = value;
			}
		}

		// Token: 0x0600D0E7 RID: 53479 RVA: 0x0022F0A2 File Offset: 0x0022D2A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwordTrainingSelectEndingCsReq);
		}

		// Token: 0x0600D0E8 RID: 53480 RVA: 0x0022F0B0 File Offset: 0x0022D2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwordTrainingSelectEndingCsReq other)
		{
			return other != null && (other == this || (this.AMDMIAEJNEM == other.AMDMIAEJNEM && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D0E9 RID: 53481 RVA: 0x0022F0E0 File Offset: 0x0022D2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.AMDMIAEJNEM != 0U)
			{
				num ^= this.AMDMIAEJNEM.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D0EA RID: 53482 RVA: 0x0022F11F File Offset: 0x0022D31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D0EB RID: 53483 RVA: 0x0022F127 File Offset: 0x0022D327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D0EC RID: 53484 RVA: 0x0022F130 File Offset: 0x0022D330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.AMDMIAEJNEM != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.AMDMIAEJNEM);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D0ED RID: 53485 RVA: 0x0022F164 File Offset: 0x0022D364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.AMDMIAEJNEM != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.AMDMIAEJNEM);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D0EE RID: 53486 RVA: 0x0022F1A2 File Offset: 0x0022D3A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwordTrainingSelectEndingCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.AMDMIAEJNEM != 0U)
			{
				this.AMDMIAEJNEM = other.AMDMIAEJNEM;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D0EF RID: 53487 RVA: 0x0022F1D3 File Offset: 0x0022D3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D0F0 RID: 53488 RVA: 0x0022F1DC File Offset: 0x0022D3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AMDMIAEJNEM = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040053E2 RID: 21474
		private static readonly MessageParser<SwordTrainingSelectEndingCsReq> _parser = new MessageParser<SwordTrainingSelectEndingCsReq>(() => new SwordTrainingSelectEndingCsReq());

		// Token: 0x040053E3 RID: 21475
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053E4 RID: 21476
		public const int AMDMIAEJNEMFieldNumber = 1;

		// Token: 0x040053E5 RID: 21477
		private uint aMDMIAEJNEM_;
	}
}
