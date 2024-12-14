using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020010C3 RID: 4291
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ServerSimulateBattleFinishScNotify : IMessage<ServerSimulateBattleFinishScNotify>, IMessage, IEquatable<ServerSimulateBattleFinishScNotify>, IDeepCloneable<ServerSimulateBattleFinishScNotify>, IBufferMessage
	{
		// Token: 0x1700360B RID: 13835
		// (get) Token: 0x0600BF5C RID: 48988 RVA: 0x0020359B File Offset: 0x0020179B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ServerSimulateBattleFinishScNotify> Parser
		{
			get
			{
				return ServerSimulateBattleFinishScNotify._parser;
			}
		}

		// Token: 0x1700360C RID: 13836
		// (get) Token: 0x0600BF5D RID: 48989 RVA: 0x002035A2 File Offset: 0x002017A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ServerSimulateBattleFinishScNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700360D RID: 13837
		// (get) Token: 0x0600BF5E RID: 48990 RVA: 0x002035B4 File Offset: 0x002017B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerSimulateBattleFinishScNotify.Descriptor;
			}
		}

		// Token: 0x0600BF5F RID: 48991 RVA: 0x002035BB File Offset: 0x002017BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerSimulateBattleFinishScNotify()
		{
		}

		// Token: 0x0600BF60 RID: 48992 RVA: 0x002035C3 File Offset: 0x002017C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerSimulateBattleFinishScNotify(ServerSimulateBattleFinishScNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF61 RID: 48993 RVA: 0x002035DC File Offset: 0x002017DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ServerSimulateBattleFinishScNotify Clone()
		{
			return new ServerSimulateBattleFinishScNotify(this);
		}

		// Token: 0x0600BF62 RID: 48994 RVA: 0x002035E4 File Offset: 0x002017E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServerSimulateBattleFinishScNotify);
		}

		// Token: 0x0600BF63 RID: 48995 RVA: 0x002035F2 File Offset: 0x002017F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ServerSimulateBattleFinishScNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600BF64 RID: 48996 RVA: 0x00203610 File Offset: 0x00201810
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

		// Token: 0x0600BF65 RID: 48997 RVA: 0x00203636 File Offset: 0x00201836
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600BF66 RID: 48998 RVA: 0x0020363E File Offset: 0x0020183E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF67 RID: 48999 RVA: 0x00203647 File Offset: 0x00201847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BF68 RID: 49000 RVA: 0x00203660 File Offset: 0x00201860
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

		// Token: 0x0600BF69 RID: 49001 RVA: 0x00203686 File Offset: 0x00201886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ServerSimulateBattleFinishScNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BF6A RID: 49002 RVA: 0x002036A3 File Offset: 0x002018A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF6B RID: 49003 RVA: 0x002036AC File Offset: 0x002018AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004DB5 RID: 19893
		private static readonly MessageParser<ServerSimulateBattleFinishScNotify> _parser = new MessageParser<ServerSimulateBattleFinishScNotify>(() => new ServerSimulateBattleFinishScNotify());

		// Token: 0x04004DB6 RID: 19894
		private UnknownFieldSet _unknownFields;
	}
}
