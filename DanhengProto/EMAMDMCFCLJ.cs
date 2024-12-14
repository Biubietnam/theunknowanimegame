using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000411 RID: 1041
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EMAMDMCFCLJ : IMessage<EMAMDMCFCLJ>, IMessage, IEquatable<EMAMDMCFCLJ>, IDeepCloneable<EMAMDMCFCLJ>, IBufferMessage
	{
		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06002E38 RID: 11832 RVA: 0x0007FCA6 File Offset: 0x0007DEA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EMAMDMCFCLJ> Parser
		{
			get
			{
				return EMAMDMCFCLJ._parser;
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06002E39 RID: 11833 RVA: 0x0007FCAD File Offset: 0x0007DEAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EMAMDMCFCLJReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06002E3A RID: 11834 RVA: 0x0007FCBF File Offset: 0x0007DEBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EMAMDMCFCLJ.Descriptor;
			}
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x0007FCC6 File Offset: 0x0007DEC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EMAMDMCFCLJ()
		{
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x0007FCCE File Offset: 0x0007DECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EMAMDMCFCLJ(EMAMDMCFCLJ other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E3D RID: 11837 RVA: 0x0007FCE7 File Offset: 0x0007DEE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EMAMDMCFCLJ Clone()
		{
			return new EMAMDMCFCLJ(this);
		}

		// Token: 0x06002E3E RID: 11838 RVA: 0x0007FCEF File Offset: 0x0007DEEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EMAMDMCFCLJ);
		}

		// Token: 0x06002E3F RID: 11839 RVA: 0x0007FCFD File Offset: 0x0007DEFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EMAMDMCFCLJ other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x0007FD1C File Offset: 0x0007DF1C
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

		// Token: 0x06002E41 RID: 11841 RVA: 0x0007FD42 File Offset: 0x0007DF42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x0007FD4A File Offset: 0x0007DF4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E43 RID: 11843 RVA: 0x0007FD53 File Offset: 0x0007DF53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E44 RID: 11844 RVA: 0x0007FD6C File Offset: 0x0007DF6C
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

		// Token: 0x06002E45 RID: 11845 RVA: 0x0007FD92 File Offset: 0x0007DF92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EMAMDMCFCLJ other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x0007FDAF File Offset: 0x0007DFAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x0007FDB8 File Offset: 0x0007DFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001295 RID: 4757
		private static readonly MessageParser<EMAMDMCFCLJ> _parser = new MessageParser<EMAMDMCFCLJ>(() => new EMAMDMCFCLJ());

		// Token: 0x04001296 RID: 4758
		private UnknownFieldSet _unknownFields;
	}
}
