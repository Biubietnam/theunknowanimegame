using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020012A3 RID: 4771
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class SyncServerSceneChangeNotify : IMessage<SyncServerSceneChangeNotify>, IMessage, IEquatable<SyncServerSceneChangeNotify>, IDeepCloneable<SyncServerSceneChangeNotify>, IBufferMessage
	{
		// Token: 0x17003BDF RID: 15327
		// (get) Token: 0x0600D4D7 RID: 54487 RVA: 0x00238497 File Offset: 0x00236697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<SyncServerSceneChangeNotify> Parser
		{
			get
			{
				return SyncServerSceneChangeNotify._parser;
			}
		}

		// Token: 0x17003BE0 RID: 15328
		// (get) Token: 0x0600D4D8 RID: 54488 RVA: 0x0023849E File Offset: 0x0023669E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SyncServerSceneChangeNotifyReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003BE1 RID: 15329
		// (get) Token: 0x0600D4D9 RID: 54489 RVA: 0x002384B0 File Offset: 0x002366B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SyncServerSceneChangeNotify.Descriptor;
			}
		}

		// Token: 0x0600D4DA RID: 54490 RVA: 0x002384B7 File Offset: 0x002366B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncServerSceneChangeNotify()
		{
		}

		// Token: 0x0600D4DB RID: 54491 RVA: 0x002384BF File Offset: 0x002366BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncServerSceneChangeNotify(SyncServerSceneChangeNotify other) : this()
		{
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D4DC RID: 54492 RVA: 0x002384D8 File Offset: 0x002366D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SyncServerSceneChangeNotify Clone()
		{
			return new SyncServerSceneChangeNotify(this);
		}

		// Token: 0x0600D4DD RID: 54493 RVA: 0x002384E0 File Offset: 0x002366E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SyncServerSceneChangeNotify);
		}

		// Token: 0x0600D4DE RID: 54494 RVA: 0x002384EE File Offset: 0x002366EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SyncServerSceneChangeNotify other)
		{
			return other != null && (other == this || object.Equals(this._unknownFields, other._unknownFields));
		}

		// Token: 0x0600D4DF RID: 54495 RVA: 0x0023850C File Offset: 0x0023670C
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

		// Token: 0x0600D4E0 RID: 54496 RVA: 0x00238532 File Offset: 0x00236732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600D4E1 RID: 54497 RVA: 0x0023853A File Offset: 0x0023673A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D4E2 RID: 54498 RVA: 0x00238543 File Offset: 0x00236743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D4E3 RID: 54499 RVA: 0x0023855C File Offset: 0x0023675C
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

		// Token: 0x0600D4E4 RID: 54500 RVA: 0x00238582 File Offset: 0x00236782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SyncServerSceneChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D4E5 RID: 54501 RVA: 0x0023859F File Offset: 0x0023679F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D4E6 RID: 54502 RVA: 0x002385A8 File Offset: 0x002367A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			while (input.ReadTag() != 0U)
			{
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005523 RID: 21795
		private static readonly MessageParser<SyncServerSceneChangeNotify> _parser = new MessageParser<SyncServerSceneChangeNotify>(() => new SyncServerSceneChangeNotify());

		// Token: 0x04005524 RID: 21796
		private UnknownFieldSet _unknownFields;
	}
}
